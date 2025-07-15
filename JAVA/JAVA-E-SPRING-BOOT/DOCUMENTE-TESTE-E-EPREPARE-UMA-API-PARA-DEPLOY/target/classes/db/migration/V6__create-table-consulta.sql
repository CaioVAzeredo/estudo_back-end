CREATE TABLE consultas (
    id bigint NOT NULL AUTO_INCREMENT,
    medico_id bigint NOT NULL,
    paciente_id bigint NOT NULL,
    data datetime NOT NULL,

    PRIMARY KEY(id),
    CONSTRAINT fk_consultas_medico_id FOREIGN KEY(medico_id) REFERENCES medicos(id),
    CONSTRAINT fk_consultas_paciente_id FOREIGN KEY(paciente_id) REFERENCES pacientes(id)
);