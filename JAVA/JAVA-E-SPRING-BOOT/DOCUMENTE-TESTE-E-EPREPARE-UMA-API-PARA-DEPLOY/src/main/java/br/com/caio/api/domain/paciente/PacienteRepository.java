package br.com.caio.api.domain.paciente;

import jakarta.validation.constraints.NotNull;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.util.Optional;

public interface PacienteRepository extends JpaRepository<Paciente, Long> {
    @Query("""
            SELECT p.ativo
            FROM Paciente p
            WHERE p.id = :id
            """)
    Boolean findAtivoById(@Param("id") Long id);

    Page<Paciente> findAllByAtivoTrue(Pageable paginacao);
}
