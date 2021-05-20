package model;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

public class Port {
    private static final int looseCargoCraneProductivity = 12;
    private static final int liquidCargoCraneProductivity = 11;
    private static final int containerCargoCraneProductivity = 10;

    private ArrayList<Ship> shipsQueue;
    private final ArrayList<Crane> cranes;
    private Date currentTime;
    private int cranesComplete = 0;

    private List<Thread> threads;

    public synchronized void CompleteMinute() {
        cranesComplete++;

        if(cranesComplete < cranes.size() && !WorkCompleted()) {
            try {
                wait();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            return;
        }
        cranesComplete = 0;
        addMinute();
        notifyAll();
    }

    public Boolean WorkCompleted() {
        for(int i = 0; i < shipsQueue.size(); i++) {
            if(!shipsQueue.get(i).isUnloaded()) {
                return false;
            }
        }
        return true;
    }

    public synchronized Ship getShipToUnload(CargoType cargoType) {
        for(int i = 0; i < shipsQueue.size(); i++) {
            if((shipsQueue.get(i).getArrivalTime().equals(currentTime) ||
                    shipsQueue.get(i).getArrivalTime().before(currentTime)) &&
                    !shipsQueue.get(i).isUnloaded() &&
                    shipsQueue.get(i).getCargoType() == cargoType &&
                    shipsQueue.get(i).unloadingCranesCount() < 2) {
                return shipsQueue.get(i);
            }
        }
        return null;
    }

    private void addMinute() {
        Calendar calendar = Calendar.getInstance();
        calendar.setTime(currentTime);
        calendar.add(Calendar.MINUTE, 1);
        currentTime = calendar.getTime();
    }

    public Port() {
        cranes = new ArrayList<Crane>();
        cranes.add(new Crane(looseCargoCraneProductivity, CargoType.сыпучий, this));
        cranes.add(new Crane(liquidCargoCraneProductivity, CargoType.жидкий, this));
        cranes.add(new Crane(containerCargoCraneProductivity, CargoType.контейнер, this));
    }

    public void addCrane(CargoType type) {
        switch(type) {
            case сыпучий:
                cranes.add(new Crane(looseCargoCraneProductivity, type, this));
                break;
            case жидкий:
                cranes.add(new Crane(liquidCargoCraneProductivity, type, this));
                break;
            case контейнер:
                cranes.add(new Crane(containerCargoCraneProductivity, type, this));
                break;
        }
    }

    public int cranesOfType(CargoType type) {
        int count = 0;
        for(int i=0; i < cranes.size(); i++) {
            if(cranes.get(i).getCargoType() == type)
                count++;
        }
        return count;
    }

    public Date getCurrentTime() {
        return currentTime;
    }

    public void setShipsQueue(ArrayList<Ship> ships) {
        shipsQueue = ships;

        for(Ship ship : shipsQueue) {
            switch(ship.getCargoType()) {
                case сыпучий:
                    ship.setPlannedTimeOfStay(ship.getCargoValue() / looseCargoCraneProductivity);
                    break;
                case жидкий:
                    ship.setPlannedTimeOfStay(ship.getCargoValue() / liquidCargoCraneProductivity);
                    break;
                case контейнер:
                    ship.setPlannedTimeOfStay(ship.getCargoValue() / containerCargoCraneProductivity);
                    break;
            }

        }
    }

    public ArrayList<Ship> getShipsQueue() {
        return shipsQueue;
    }

    public void Work() {
        if(shipsQueue == null || shipsQueue.size() == 0)
            return;
        currentTime = shipsQueue.get(0).getArrivalTime();

        threads = new ArrayList<Thread>();

        for (int i = 0; i < cranes.size(); i++){
            threads.add(new Thread(cranes.get(i)));
        }

        for (Thread thread: threads) {
            thread.start();
        }
        for (Thread thread: threads) {
            try {
                thread.join();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
