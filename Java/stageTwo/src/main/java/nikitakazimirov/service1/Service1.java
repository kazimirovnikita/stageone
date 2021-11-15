package nikitakazimirov.service1;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collections;
import java.util.Comparator;
import java.util.GregorianCalendar;
import java.util.Random;

import nikitakazimirov.model.CargoType;
import nikitakazimirov.model.JsonSerializer;
import nikitakazimirov.model.Ship;

public class Service1 {
    //Генератор случайных чисел
    private static final Random rnd = new Random();

    //Метод генерации расписания прибытия кораблей
    public static String GenerateShipsSchedule(int shipsCount) throws IOException {

        ArrayList<Ship> schedule = new ArrayList<Ship>();

        Calendar c;

        for(int i = 0; i < shipsCount; i++) {
            Ship ship = new Ship();

            ship.setCargoType(CargoType.values()[rnd.nextInt(3)]);
            ship.setName("Корабль №" + i);

            c = new GregorianCalendar(2021, Calendar.APRIL,
                    1 + rnd.nextInt(30), rnd.nextInt(24), rnd.nextInt(60), 00);
            c.add(Calendar.DATE, -7 + rnd.nextInt(14));

            ship.setArrivalTime(c.getTime());
            ship.setCargoValue(1000 * (1 + rnd.nextInt(20)));
            ship.setUnloadingDelay(rnd.nextInt(1440));

            schedule.add(ship);
        }

        return JsonSerializer.toJson(schedule);
    }
}
