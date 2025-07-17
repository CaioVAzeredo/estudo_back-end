package br.com.caio.api.domain.paciente;

import br.com.caio.api.domain.endereco.DadosEndereco;
import br.com.caio.api.domain.endereco.Endereco;
import jakarta.validation.Valid;
import jakarta.validation.constraints.Email;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Pattern;

public record DadosCadastroPaciente(
        @NotBlank
        String nome,

        @NotBlank
        @Email
        String email,

        @NotNull
        String telefone,

        @NotBlank
        @Pattern(regexp = "\\d{11}")
        String cpf,


        @NotNull
        @Valid
        DadosEndereco endereco
        ) {
}
