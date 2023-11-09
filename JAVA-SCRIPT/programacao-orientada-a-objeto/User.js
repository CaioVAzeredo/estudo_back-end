export default class User {
    7
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

    get nome() {
        //Pode ter lógica como if
        return this.#nome;
    }

    get email() {
        //Pode ter lógica como if
        return this.#email;
    }

    get nascimento() {
        //Pode ter lógica como if
        return this.#nascimento;
    }

    get ativo() {
        //Pode ter lógica como if
        return this.#ativo;
    }

    get role() {
        //Pode ter lógica como if
        return this.#role;
    }
    
    set nome(novoNome){
        if(novoNome ===''){
            throw new Error('Formato não válido');
        }
        this.#nome = novoNome;
    }

    /*          usado apenas como exemplo
            
    #montaObjUser() { //função privada, não conseguimos acessar de fora do objeto 
        return ({
            nome: this.#nome,
            email: this.#email,
            nascimento: this.#nascimento,
            role: this.#role,
            ativo: this.#ativo
        })
    } */

    exibirInfos() {
        /* const objUser = this.#montaObjUser()  */// forma de acessar uma função de fora é passando para uma variável
       /*  return `${objUser.nome}, ${objUser.email}, ${objUser.nascimento}, ${objUser.role}, ${objUser.ativo}` // se refere à variavel objUser */
        return `${this.nome}, ${this.email}, ${this.nascimento}, ${this.role}, ${this.ativo}` //acessando sem a # pois se refere aos getters 
    }

}


