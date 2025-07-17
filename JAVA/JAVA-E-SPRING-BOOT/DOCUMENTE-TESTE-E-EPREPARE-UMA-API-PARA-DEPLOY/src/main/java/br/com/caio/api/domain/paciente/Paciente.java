package br.com.caio.api.domain.paciente;

import br.com.caio.api.domain.endereco.Endereco;
import jakarta.persistence.*;
import jakarta.validation.Valid;
import lombok.AllArgsConstructor;
import lombok.EqualsAndHashCode;
import lombok.Getter;
import lombok.NoArgsConstructor;


@Table(name = "pacientes")
@Entity(name = "Paciente")
@Getter
@NoArgsConstructor
@AllArgsConstructor
@EqualsAndHashCode(of = "id")
public class Paciente {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String nome;
    private String email;

    @Column(nullable = false)
    private String cpf;

    @Embedded
    private Endereco endereco;
    private String telefone;
    private boolean ativo;


    public Paciente(DadosCadastroPaciente dados) {
        this.ativo = true;
        this.nome = dados.nome();
        this.cpf = dados.cpf();
        this.email = dados.email();
        this.endereco = new Endereco(dados.endereco());
        this.telefone = dados.telefone();
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public boolean isAtivo() {
        return ativo;
    }

    public void setAtivo(boolean ativo) {
        this.ativo = ativo;
    }

    public void atualizarInformacoes(@Valid DadosAtualizacaoPaciente dados){
        if(dados.nome() != null){
            this.nome = dados.nome();
        }

        if (dados.telefone() != null){
            this.telefone = dados.telefone();
        }

        if(dados.endereco() != null){
            this.endereco.atualizarEndereco(dados.endereco());
        }
    }

    public void excluir(){
        this.ativo = false;
    }
}
