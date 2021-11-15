package main;

import java.io.IOException;

import service2.Service2;

public class Main {

    public static void main(String[] args) {

        try {
            Service2.Processing(150);
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

}
