package nikitakazimirov.service3;

import nikitakazimirov.model.*;
import nikitakazimirov.service1.Service1;
import org.springframework.context.i18n.LocaleContextHolder;
import org.springframework.http.HttpEntity;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.client.RestTemplate;
import org.springframework.web.server.ResponseStatusException;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Locale;

@RequestMapping(value = "/service3")
@Controller
public class Service3Controller {
    @PostMapping("/simulation")
    @ResponseBody
    public void simulation(@RequestParam Integer shipsCount) {
        RestTemplate rt = new RestTemplate();
        String scheduleAddress = "http://localhost:8084/service2/getSchedule?shipsCount=" + shipsCount;
        String schedule = rt.getForEntity(scheduleAddress, String.class).getBody();
        Port port = new Port();
        Service3 service3 = new Service3();
        service3.setPort(port);
        try {
            ArrayList<Ship> resultJson = service3.UnloadingSimulation(schedule);
            String resultAddress = "http://localhost:8084/service2/saveResult?bulk=" +
                    port.cranesOfType(CargoType.сыпучий) + "&liquid=" +
                    port.cranesOfType(CargoType.жидкий) + "&container=" +
                    port.cranesOfType(CargoType.контейнер);
            rt.postForEntity(resultAddress, resultJson, String.class);
        } catch (IOException e) {
            e.printStackTrace();
            throw new ResponseStatusException(HttpStatus.INTERNAL_SERVER_ERROR, "Error in service3");
        }
    }
}
