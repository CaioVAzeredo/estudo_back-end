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

function ligaParaCliente(telefoneComercial, telefoneResidencial) {
    console.log(`Ligando para ${telefoneComercial}`)
    console.log(`Ligando para ${telefoneResidencial}`)
}

ligaParaCliente(...cliente.telefone) //seria passar ligaParaCliente(cliente.telefone[0], cliente.telefone[1])

const encomenda = {
    destinatario: cliente.nome,
    ...cliente.enderecos[0],
}

console.log(encomenda)