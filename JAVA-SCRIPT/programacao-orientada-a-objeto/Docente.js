import User from './User.js';

class Docente extends User{
    constructor(nome, email, nascimento, role = 'admin', ativo = true){
        super(nome, email, nascimento, role, ativo);
    }
    aprovarEstudante(Estudante, curso){
        return `O/A aluno/a ${Estudante} está aprovado no curso ${curso}`;
    }
}

const novoDocente = new Docente('Fernando', 'F@F.com', '1960-21-11');
console.log(novoDocente.exibirInfos());
console.log(novoDocente.aprovarEstudante('Caio', 'POO'));