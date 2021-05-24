package nikitakazimirov.model;

import java.io.*;
import java.util.Date;
import java.util.concurrent.TimeUnit;
import java.util.stream.Stream;

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

    public static String readFromFile(FileReader fileReader) throws IOException {
        BufferedReader in = new BufferedReader(fileReader);
        StringBuilder sb = new StringBuilder();
        String line;
        while((line = in.readLine()) != null) {
            sb.append(line);
        }
        String contents = sb.toString();
        in.close();
        return contents;
    }
}
