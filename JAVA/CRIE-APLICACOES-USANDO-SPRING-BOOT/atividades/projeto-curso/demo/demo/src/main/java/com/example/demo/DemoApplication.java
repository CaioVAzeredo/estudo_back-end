package com.example.demo;

import org.springframework.boot.autoconfigure.SpringBootApplication;
import com.example.demo.principal.Principal;

@SpringBootApplication
public class DemoApplication {

    public static void main(String[] args) {
        Principal principal = new Principal();
        principal.exibir();
    }

}
