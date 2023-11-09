import User from "./User.js";

export default class Admin extends User {
    constructor(nome, email, nascimento, role = 'admin', ativo = true) {
        super(nome, email, nascimento, role, ativo); //super() serve para pegar as caracteristicas da class que foi extendida
    }
    
    criarCurso(nomeDoCurso, vagas){
        return`Curso de ${nomeDoCurso} criado com ${vagas} vagas`;
    }

    exibirInfos(){
        return `${this.nome}, ${this.ativo}`
    }
}

