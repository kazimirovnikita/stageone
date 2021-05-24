package nikitakazimirov.service1;

import com.fasterxml.jackson.core.JsonProcessingException;
import nikitakazimirov.model.CargoType;
import nikitakazimirov.model.JsonSerializer;
import nikitakazimirov.model.Ship;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.server.ResponseStatusException;

import java.io.IOException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;

@RequestMapping(value = "/service1")
@Controller
public class Service1Controller {
    @GetMapping(value ="/generateShipsSchedule")
    @ResponseBody
    public String generateShipsSchedule(@RequestParam Integer shipsCount) {
        if (shipsCount == null) {
            shipsCount = 5;
        }
        if (shipsCount <= 0){
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Incorrect ships count");
        }
        try {
            String json = Service1.GenerateShipsSchedule(shipsCount);
            ArrayList<Ship> schedule = JsonSerializer.fromJson(json);
            Scanner scanner = new Scanner(System.in);
            Random rnd = new Random();
            while (true){
                System.out.println("Добавить корабль вручную? Y/N");
                String answer = scanner.nextLine();
                if(!answer.equals("y"))
                    break;

                System.out.println("Наименование корабля:");
                String name;
                name = scanner.nextLine();

                System.out.println();
                System.out.println("Тип груза: 1. Сыпучий, 2. Жидкий, 3. Контейнер");

                int input;
                try {
                    input = scanner.nextInt();
                }
                catch (Exception ex) {
                    System.out.println("Некорректный ввод");
                    continue;
                }
                if(input < 1 || input > 3){
                    System.out.println("Некорректный ввод");
                    continue;
                }
                CargoType type = CargoType.values()[input - 1];

                System.out.print("Количество груза (целое число): ");

                try {
                    input = scanner.nextInt();
                }
                catch (Exception ex) {
                    System.out.println("Некорректный ввод");
                    continue;
                }
                if(input < 1){
                    System.out.println("Некорректный ввод");
                    continue;
                }

                int cargoValue = input;

                scanner.nextLine();

                DateFormat format = new SimpleDateFormat("yyyy-MM-dd HH:mm",
                        Locale.US);

                Date date = null;
                while (date == null) {
                    System.out.print("Введите дату прибытия корабля в порт в формате yyyy-MM-dd HH:mm: ");
                    String line = scanner.nextLine();
                    try {
                        date = format.parse(line);
                    } catch (ParseException ex) {
                        ex.printStackTrace();
                        System.out.println("Некорректный ввод");
                    }
                }

                Ship ship = new Ship();
                ship.setName(name);
                ship.setCargoType(type);
                ship.setArrivalTime(date);
                ship.setCargoValue(cargoValue);
                ship.setUnloadingDelay(rnd.nextInt(1440));

                schedule.add(ship);
            }

            Collections.sort(schedule, new Comparator<Ship>() {
                public int compare(Ship left, Ship right) {
                    return left.getArrivalTime().after(right.getArrivalTime()) ? 1 :
                            (left.getArrivalTime().before(right.getArrivalTime())) ? -1 : 0;
                }
            });
            return JsonSerializer.toJson(schedule);
        } catch (IOException e) {
            e.printStackTrace();
            throw new ResponseStatusException(HttpStatus.INTERNAL_SERVER_ERROR, "Error in service1");
        }
    }
}
