package com.example.demo;


import com.example.demo.model.Tarefa;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.io.File;
import java.io.IOException;


@SpringBootApplication
public class DemoApplication {

    public static void main(String[] args) {

        ObjectMapper objectMapper = new ObjectMapper();
        Tarefa tarefa = new Tarefa("descrição aqui", true, "Caio");

        try {
            objectMapper.writeValue(new File("tarefa.json"), tarefa);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

}
