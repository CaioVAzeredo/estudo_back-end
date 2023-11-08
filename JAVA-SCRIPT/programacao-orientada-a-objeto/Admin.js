import User from "./User.js";

class Admin extends User {
    constructor(nome, email, nascimento, role = 'admin', ativo = true) {
        super(nome, email, nascimento, role, ativo); //super() serve para pegar as caracteristicas da class que foi extendida
    }
    criarCurso(nomeDoCurso, vagas){
        return`Curso de ${nomeDoCurso} criado com ${vagas} vagas`;
    }
}

const novoAdmin = new Admin('Caio', 'c@c.com', '23/08/1998');
console.log(novoAdmin.criarCurso('JS', 20));