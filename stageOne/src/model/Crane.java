package model;

import java.util.Date;

public class Crane implements Runnable {

    private int productivity;
    private CargoType cargoType;
    private Port port;
    private Ship unloadingShip;
    private Date currentTime;


    public Crane(int productivity, CargoType cargoType, Port port) {
        this.productivity = productivity;
        this.cargoType = cargoType;
        this.port = port;
    }

    public int getProductivity() {
        return productivity;
    }

    public CargoType getCargoType() {
        return cargoType;
    }

    public void run() {

        while(!port.WorkCompleted()) {
            currentTime = port.getCurrentTime();

            if(unloadingShip == null) {
                Ship ship = port.getShipToUnload(cargoType);
                if(ship != null && ship.addCrane(this))
                    unloadingShip = ship;
                if(unloadingShip != null &&
                        unloadingShip.getStartUnloadingTime() == null) {
                    unloadingShip.setStartUnloadingTime(currentTime);
                    System.out.println(unloadingShip.getName() + " unloading");
                }
            }

            if(unloadingShip != null)
                unloadingShip.unload();

            if(unloadingShip != null &&
                    unloadingShip.isUnloaded()) {
                unloadingShip.endUnloading();

                if(unloadingShip != null && unloadingShip.getEndUnloadingTime() == null)
                    unloadingShip.setEndUnloadingTime(currentTime);

                unloadingShip = null;
            }

            port.CompleteMinute();
        }
    }

}
