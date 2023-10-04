const clientes = require("./AtividadeCliente.json")

function clienteQueNaoTemComplemento(clientes) {
    return clientes.filter((cliente) => {
        return (cliente.endereco.apartamento && !cliente.endereco.hasOwnProperty("complemento"))
    })
}

const filtrados = clienteQueNaoTemComplemento(clientes)

console.log(filtrados)