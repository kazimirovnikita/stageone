package service3;

import java.io.IOException;
import java.util.ArrayList;

import model.CargoType;
import model.Helper;
import model.JsonSerializer;
import model.Port;
import model.Ship;

public class Service3 {
    private Port port;

    public void setPort(Port port) {
        this.port = port;
    }

    public String UnloadingSimulation(String json) throws IOException {

        while(true) {
            ArrayList<Ship> ships = JsonSerializer.fromJson(json);
            port.setShipsQueue(ships);
            port.Work();
            if(Optimize(port.getShipsQueue()))
                break;
        }

        return JsonSerializer.toJson(port.getShipsQueue());
    }

    private boolean Optimize(ArrayList<Ship> ships) {
        int totalFine = 0, looseFine = 0, liquidFine = 0, containerFine = 0;

        for(Ship ship : ships) {
            long realWaitingTime = Helper.getDurationInMinutes(ship.getArrivalTime(), ship.getEndUnloadingTime());
            int fine = (int) ((realWaitingTime - ship.getPlannedTimeOfStay()) / 60 * 100);
            fine = fine < 0 ? 0 : fine;

            totalFine += fine;

            switch(ship.getCargoType()) {
                case сыпучий:
                    looseFine += fine;
                    break;
                case жидкий:
                    liquidFine += fine;
                    break;
                case контейнер:
                    containerFine += fine;
                    break;
            }
        }

        if(totalFine <= 30000)
            return true;

        if(looseFine >= liquidFine && looseFine >= containerFine)
            port.addCrane(CargoType.сыпучий);
        else if(liquidFine >= looseFine && liquidFine >= containerFine)
            port.addCrane(CargoType.жидкий);
        else
            port.addCrane(CargoType.контейнер);

        return false;
    }
}
