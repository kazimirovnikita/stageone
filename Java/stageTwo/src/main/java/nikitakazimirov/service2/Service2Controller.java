package nikitakazimirov.service2;

import nikitakazimirov.model.CargoType;
import nikitakazimirov.model.Helper;
import nikitakazimirov.model.JsonSerializer;
import nikitakazimirov.model.Ship;
import org.springframework.context.i18n.LocaleContextHolder;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.client.RestTemplate;
import org.springframework.web.server.ResponseStatusException;

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Locale;

@RequestMapping(value = "/service2")
@Controller
public class Service2Controller {
    final private String scheduleFilename = "schedule.json";
    final private String resultFilename = "result.json";

    @PostMapping("/saveResult")
    @ResponseBody
    public void saveReport(@RequestBody ArrayList<Ship> unloadings,
                           @RequestParam(name = "bulk") Integer bulkCranes,
                           @RequestParam(name = "liquid") Integer liquidCranes,
                           @RequestParam(name = "container") Integer containerCranes){
        try {
            Helper.saveToFile(JsonSerializer.toJson(unloadings), System.getProperty("user.dir") + "/" + resultFilename);
        } catch (IOException e) {
            e.printStackTrace();
        }
        int totalFine = 0, totalWaiting = 0, totalUnloading = 0, maxDelay = 0, currentDelay;
        for (Ship unloading : unloadings) {
            System.out.println(unloading);
            totalWaiting += Helper.getDurationInMinutes(unloading.getArrivalTime(),
                    unloading.getStartUnloadingTime());
            currentDelay = (int) Helper.getDurationInMinutes(unloading.getArrivalTime(),
                    unloading.getEndUnloadingTime()) -
                    unloading.getPlannedTimeOfStay();
            currentDelay = currentDelay < 0 ? 0 : currentDelay;

            totalUnloading += currentDelay;
            if (currentDelay > maxDelay)
                maxDelay = currentDelay;

            long realWaitingTime = Helper.getDurationInMinutes(unloading.getArrivalTime(), unloading.getEndUnloadingTime());
            int fine = (int) ((realWaitingTime - unloading.getPlannedTimeOfStay()) / 60 * 100);
            fine = fine < 0 ? 0 : fine;
            totalFine += fine;
        }

        System.out.println("Всего разгрузок: " + unloadings.size());
        System.out.println("Количество кранов для разгрузки сыпучего груза: " + bulkCranes);
        System.out.println("Количество кранов для разгрузки жидкого груза: " + liquidCranes);
        System.out.println("Количество кранов для разгрузки контейнеров: " + containerCranes);
        System.out.println("Всего начислено штрафа: " + totalFine);
        System.out.println("Среднее время ожидание в очереди: " +
                Helper.minutesToString(totalWaiting / unloadings.size()));
        System.out.println("Среднее время задержки разгрузки: " +
                Helper.minutesToString(totalUnloading / unloadings.size()));
        System.out.println("Максимальное время задержки разгрузки: " +
                Helper.minutesToString(maxDelay));
    }

    @GetMapping(value = "/getSchedule")
    @ResponseBody
    public String getSchedule(@RequestParam Integer shipsCount) {
        RestTemplate restTemplate = new RestTemplate();
        String address = "http://localhost:8081/service1/generateShipsSchedule?shipsCount=" + shipsCount;
        String json = restTemplate.getForEntity(address, String.class).getBody();
        if (json == null) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Empty schedule");
        }
        try {
            FileWriter writer = new FileWriter(System.getProperty("user.dir") + "/" + scheduleFilename);
            writer.write(json);
            writer.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return json;
    }

    @GetMapping(value = "/readSchedule")
    @ResponseBody
    public ArrayList<Ship> readSchedule(@RequestParam String filename) {
        File file = new File(filename);
        FileReader fileReader = null;
        try {
            fileReader = new FileReader(file);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Incorrect filename");
        }
        try {
            String json = Helper.readFromFile(fileReader);
            return JsonSerializer.fromJson(json);
        } catch (IOException e) {
            e.printStackTrace();
            throw new ResponseStatusException(HttpStatus.INTERNAL_SERVER_ERROR, "Error in service2");
        }
    }

    @GetMapping(value ="/processing")
    @ResponseBody
    public String processing(@RequestParam Integer shipsCount) {
        RestTemplate rt = new RestTemplate();
        String address = "http://localhost:8083/service3/simulation?shipsCount=" + shipsCount;
        rt.postForEntity(address, "",String.class);
        try {
            return Files.readString(Paths.get(System.getProperty("user.dir") + "/" + resultFilename));
        } catch (IOException e) {
            throw new ResponseStatusException(HttpStatus.INTERNAL_SERVER_ERROR, "Error in reading report");
        }
    }
}
