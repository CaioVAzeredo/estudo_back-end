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


cliente.enderecos.push({
    rua: "qi 5/6",
    numero: 302,
    apartamento: true,
    complemento: 'N/A'
})

/* console.log(cliente["enderecos"]) */ //console.log(cliente.enderecos)

const listaDeAparatamentos = cliente.enderecos.filter((endereco) => endereco.apartamento === true)

console.log(listaDeAparatamentos)