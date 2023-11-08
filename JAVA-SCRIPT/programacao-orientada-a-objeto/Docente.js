import User from './User.js';

export default class Docente extends User{
    constructor(nome, email, nascimento, role = 'admin', ativo = true){
        super(nome, email, nascimento, role, ativo);
    }
    aprovarEstudante(Estudante, curso){
        return `O/A aluno/a ${Estudante} está aprovado no curso ${curso}`;
    }
}

