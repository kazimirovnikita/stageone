package model;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class Helper {

    public static long getDurationInMinutes(Date earlier, Date later) {
        long durationInMillisec = later.getTime() - earlier.getTime();
        long durationInMinutes = TimeUnit.MILLISECONDS.toMinutes(durationInMillisec);
        return durationInMinutes;
    }

    public static String minutesToString(long durationInMinutes) {
        int minutes = (int)(durationInMinutes % 60);
        durationInMinutes /= 60;
        int hours = (int)(durationInMinutes % 24);
        durationInMinutes /= 24;
        int days = (int)durationInMinutes;
        return days + ":" + hours + ":" + minutes;
    }

    public static void saveToFile(String jsonToSave, String pathToFile) throws IOException {
        FileWriter fileWriter = new FileWriter(pathToFile);
        PrintWriter printWriter = new PrintWriter(fileWriter);
        printWriter.print(jsonToSave);
        printWriter.close();
    }
}
