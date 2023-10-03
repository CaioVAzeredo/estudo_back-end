const cliente = {
    nome: "joao",
    idade: "24",
    email: "joao@firma.com",
    telefone: ["11 0988908890", "11 983712893"],
}

cliente.enderecos = [
    {
        rua: "qnf 22",
        numero: 1233,
        apartamento: false,
        complemento: 'casa: 20'
    }
]

for(let chave in cliente){
    let tipo = typeof cliente[chave]
    if(tipo!=="object" && tipo!== "function"){
        console.log(`A chave: ${chave} tem o valor: ${cliente[chave]}`)
    }
}