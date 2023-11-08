export default class User {7
    #nome; // o # serve para privar a variável 
    #email;
    #nascimento;
    #role;
    #ativo;
    constructor(nome, email, nascimento, role, ativo = true) {
        this.#nome = nome;
        this.#email = email;
        this.#nascimento = nascimento;
        this.#role = role || 'estudante';
        this.#ativo = ativo;
    }
    exibirInfos() {
        return `${this.#nome}, ${this.#email}`
    }
}


