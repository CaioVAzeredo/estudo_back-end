import User from "./User.js";
import Docente from "./Docente.js";
import Admin from "./Admin.js";

/* const novoUsuario = new User("caio", "c@c.com", "23/08/1998"); 
console.log(novoUsuario.exibirInfos());*/

//novoUsuario.#nome = 'Joao' // nao pode atribuir novo valor para #nome pois está privado e tem que ser mudado somente dentro da class User 
const novoAdm = new Admin("Lucas", "L@L.com", "23/08/2009");
console.log(novoAdm.nome); // se refere ao get na class User
novoAdm.nome = ""; //atribuindo novo valor a nome pelo set da class User
console.log(novoAdm.nome);