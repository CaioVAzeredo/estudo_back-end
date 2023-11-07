import User from "./User.js";

class Admin extends User {
    constructor(nome, email, nascimento, role = 'admin', ativo = true) {
        super(nome, email, nascimento, role, ativo) //super() serve para pegar as caracteristicas da class que foi extendida
    }
}