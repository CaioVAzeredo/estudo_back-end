/* function User(nome, email) {
    this.nome = nome;
    this.email = email;
    
    this.exibirInfos = function(){
        return `${this.nome}, ${this.email}`;
    } 
} */

/* ------- Uma forma de fazer objeto -------*/
// const novoUser = new User('Caio', 'c@c.com');
// console.log(novoUser.exibirInfos());


/* ------- Outra forma de fazer objeto -------*/
/* function Admin(role){
    User.call(this, 'Caio', 'c@c.com'); //Primeiro parâmetro é a herança de User. Os outros dois é a atribuição das variáveis sendo passadas então nome = Caio e email = c@c.js.
    this.role = role || 'estudante'; // atribuindo role e recebendo como parâmetro, se nao receber nada, recebe estudante como padrão.
}

Admin.prototype = Object.create(User.prototype);//passando para o prototype de admin o Object.create() que serve para cria um objeto a propriedade prototype da função User, entao podemos criar um novo objeto.
const novoUser = new Admin('admin');
console.log(novoUser.exibirInfos());
console.log(novoUser.role); */


/* --------------------------------------------------------------- */

/* --------------Objeto literal ------------- */
const user = { 
    init: function(nome, email){ //init substitui a função construtora
        this.nome = nome;
        this.email = email;
    },
    exibirInfos: function(){
        return this.nome; 
    }
}

const novoUser = Object.create(user); //criando a variavel e colocando o objeto nele.
novoUser.init('Caio', 'c@c.com'); //atribuindo valores para os parametros de init no objeto.
console.log(novoUser.exibirInfos()) //mostrando as informações de exibirInfos().

// console.log(novoUser.exibirInfos('Caio'));
// console.log(user.isPrototypeOf(novoUser));