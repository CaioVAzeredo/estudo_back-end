const user = {
    nome: "Caio",
    email: "c@gmail.com",
    nascimento: "1998/08/23",
    role: "adm",
    ativo: true,
    exibeInfos: function(){
        console.log(this.nome, this.email)
    }
}

/* Nao da certo pois perde a propriedade 

user.exibeInfos()
const exibir = user.exibeInfos 
exibe() */

const exibir = function(){
    console.log(this.nome)
}

const exibirNome = exibir.bind(user); //bind() serve para juntar as propriedades de user com a função exibir

exibirNome() 
exibir()