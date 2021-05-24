package nikitakazimirov.main;

import nikitakazimirov.service2.Service2;

import java.io.IOException;

public class Main {
    public static void main(String[] args) {

        try {
            Service2.Processing(150);
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

}
