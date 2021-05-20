package service2;

import java.io.IOException;
import java.util.ArrayList;

import model.CargoType;
import model.Helper;
import model.JsonSerializer;
import model.Port;
import model.Ship;
import service1.Service1;
import service3.Service3;

public class Service2 {
    public static void Processing(int shipsCount) throws IOException {

        try {
            Port port = new Port();
            Service3 service3 = new Service3();
            service3.setPort(port);
            String json = Service1.GenerateShipsSchedule(shipsCount);
            Helper.saveToFile(json, "schedule.json");
            String resultJson = service3.UnloadingSimulation(json);
            Helper.saveToFile(resultJson, "result.json");

            ArrayList<Ship> unloadings = JsonSerializer.fromJson(resultJson);

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
