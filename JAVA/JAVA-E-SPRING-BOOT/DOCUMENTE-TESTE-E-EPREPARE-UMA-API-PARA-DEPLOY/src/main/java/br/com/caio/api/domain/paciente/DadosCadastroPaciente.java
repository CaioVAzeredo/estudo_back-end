package br.com.caio.api.domain.paciente;

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

        @NotBlank
        @Pattern(regexp = "\\d{12}")
        String cpf,

        @NotNull
        @Valid
        String telefone,

        @NotNull
        Endereco dadosEndereco
        ) {
}
