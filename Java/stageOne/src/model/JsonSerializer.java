package model;

import java.io.IOException;
import java.io.StringReader;
import java.io.StringWriter;
import java.util.ArrayList;

import com.fasterxml.jackson.databind.JavaType;
import com.fasterxml.jackson.databind.ObjectMapper;

public class JsonSerializer {

    public static String toJson(ArrayList<Ship> schedule) throws IOException {
        StringWriter writer = new StringWriter();
        ObjectMapper mapper = new ObjectMapper();
        mapper.writeValue(writer, schedule);
        return writer.toString();
    }

    public static ArrayList<Ship> fromJson(String json) throws IOException {
        StringReader reader = new StringReader(json);
        ObjectMapper mapper = new ObjectMapper();
        JavaType javaType = getCollectionType(ArrayList.class, Ship.class);
        ArrayList<Ship> schedule = mapper.readValue(reader, javaType);
        return schedule;
    }

    public static JavaType getCollectionType(Class<?> collectionClass, Class<?>... elementClasses) {
        ObjectMapper mapper = new ObjectMapper();
        return mapper.getTypeFactory().constructParametricType(collectionClass, elementClasses);
    }

}
