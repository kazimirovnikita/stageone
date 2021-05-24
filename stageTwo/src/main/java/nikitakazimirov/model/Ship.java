package nikitakazimirov.model;

import java.util.Date;
import java.util.ArrayList;

import com.fasterxml.jackson.annotation.JsonIgnore;

public class Ship {
    private String name;
    private CargoType cargoType;
    private int cargoValue;
    private Date arrivalTime;
    private int plannedTimeOfStay;
    private int unloadingDelay;
    private Date startUnloadingTime;
    private Date endUnloadingTime;

    @JsonIgnore
    private ArrayList<Crane> unloadingCranes;

    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public CargoType getCargoType() {
        return cargoType;
    }
    public void setCargoType(CargoType cargoType) {
        this.cargoType = cargoType;
    }
    public int getCargoValue() {
        return cargoValue;
    }
    public void setCargoValue(int cargoValue) {
        this.cargoValue = cargoValue;
    }
    public Date getArrivalTime() {
        return arrivalTime;
    }
    public void setArrivalTime(Date arrivalTime) {
        this.arrivalTime = arrivalTime;
    }
    public int getPlannedTimeOfStay() {
        return plannedTimeOfStay;
    }
    public void setPlannedTimeOfStay(int plannedTimeOfStay) {
        this.plannedTimeOfStay = plannedTimeOfStay;
    }
    public int getUnloadingDelay() {
        return unloadingDelay;
    }
    public void setUnloadingDelay(int unloadingDelay) {
        this.unloadingDelay = unloadingDelay;
    }
    public Date getStartUnloadingTime() {
        return startUnloadingTime;
    }
    public void setStartUnloadingTime(Date startUnloadingTime) {
        this.startUnloadingTime = startUnloadingTime;
    }
    public Date getEndUnloadingTime() {
        return endUnloadingTime;
    }
    public void setEndUnloadingTime(Date endUnloadingTime) {
        this.endUnloadingTime = endUnloadingTime;
    }

    public String waitingInQueue() {
        long duration = Helper.getDurationInMinutes(arrivalTime, startUnloadingTime);
        return Helper.minutesToString(duration);
    }

    public String unloadingDuration() {
        long duration = Helper.getDurationInMinutes(startUnloadingTime, endUnloadingTime);
        return Helper.minutesToString(duration);
    }

    @JsonIgnore
    public boolean isEmpty() {
        return cargoValue <= 0;
    }

    @JsonIgnore
    public boolean isUnloaded() {
        return cargoValue <= 0 && unloadingDelay <=0;
    }

    public int unloadingCranesCount() {
        if(unloadingCranes == null)
            return 0;
        return unloadingCranes.size();
    }

    public synchronized boolean addCrane(Crane crane) {
        if(unloadingCranes == null)
            unloadingCranes = new ArrayList<Crane>();

        if(cargoType != crane.getCargoType() || unloadingCranes.size() == 2)
            return false;

        unloadingCranes.add(crane);
        return true;
    }

    public synchronized void unload() {
        if(isEmpty()) {
            unloadingDelay--;
            return;
        }

        for(int i=0; i < unloadingCranes.size(); i++) {
            cargoValue -= unloadingCranes.get(i).getProductivity();
        }
    }

    public void endUnloading() {
        unloadingCranes.clear();
        cargoValue = 0;
        unloadingDelay = 0;
        System.out.println(name + " unloaded");
    }

    @Override
    public String toString() {
        return "Наименование: " + name +
                ", Тип груза: " + cargoType +
                ", Дата прибытия: " + arrivalTime +
                ", Ожидание в очереди: " + waitingInQueue() +
                ", Начало разгрузки: " + startUnloadingTime +
                ", Длительность разгрузки: " + unloadingDuration();
    }
}
