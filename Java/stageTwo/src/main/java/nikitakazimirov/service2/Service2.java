package nikitakazimirov.service2;

import java.io.IOException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;

import nikitakazimirov.model.*;
import nikitakazimirov.service1.Service1;
import nikitakazimirov.service3.Service3;


public class Service2 {
    public static void Processing(int shipsCount) throws IOException {

        try {
            Port port = new Port();
            Service3 service3 = new Service3();
            service3.setPort(port);
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

            json = JsonSerializer.toJson(schedule);

            Helper.saveToFile(json, "schedule.json");

            ArrayList<Ship> resultJson = service3.UnloadingSimulation(json);
            Helper.saveToFile(JsonSerializer.toJson(resultJson), "result.json");

            ArrayList<Ship> unloadings = JsonSerializer.fromJson(JsonSerializer.toJson(resultJson));

            int totalFine = 0, totalWaiting = 0, totalUnloading = 0, maxDelay = 0, currentDelay;

            for(Ship unloading : unloadings) {
                System.out.println(unloading);
                totalWaiting += Helper.getDurationInMinutes(unloading.getArrivalTime(),
                        unloading.getStartUnloadingTime());
                currentDelay = (int)Helper.getDurationInMinutes(unloading.getArrivalTime(),
                        unloading.getEndUnloadingTime()) -
                        unloading.getPlannedTimeOfStay();
                currentDelay = currentDelay < 0 ? 0 : currentDelay;

                totalUnloading += currentDelay;
                if(currentDelay > maxDelay)
                    maxDelay = currentDelay;

                long realWaitingTime = Helper.getDurationInMinutes(unloading.getArrivalTime(), unloading.getEndUnloadingTime());
                int fine = (int) ((realWaitingTime - unloading.getPlannedTimeOfStay()) / 60 * 100);
                fine = fine < 0 ? 0 : fine;
                totalFine += fine;
            }

            System.out.println("Всего разгрузок: " + unloadings.size());
            System.out.println("Количество кранов для разгрузки сыпучего груза: " +
                    port.cranesOfType(CargoType.сыпучий));
            System.out.println("Количество кранов для разгрузки жидкого груза: " +
                    port.cranesOfType(CargoType.жидкий));
            System.out.println("Количество кранов для разгрузки контейнеров: " +
                    port.cranesOfType(CargoType.контейнер));
            System.out.println("Всего начислено штрафа: " + totalFine);
            System.out.println("Среднее время ожидание в очереди: " +
                    Helper.minutesToString(totalWaiting / unloadings.size()));
            System.out.println("Среднее время задержки разгрузки: " +
                    Helper.minutesToString(totalUnloading / unloadings.size()));
            System.out.println("Максимальное время задержки разгрузки: " +
                    Helper.minutesToString(maxDelay));
        }
        catch(IOException ex) {
            System.out.println(ex.getMessage());
        }
    }
}
