//buscando informação do arquivo cliente.json
console.log("------------------TRANFORMAR JSON EM OBJETO---------------------------")
const dados = require("./cliente.json")
console.log(dados)
console.log(typeof (dados))

console.log("---------------------TRANFORMAR OBJETO EM JSON------------------------")
const clienteEmString = JSON.stringify(dados)
console.log(clienteEmString)
console.log(typeof (clienteEmString))

console.log("------------------OUTRA FORMA DE TRANFORMAR JSON EM OBJETO---------------------------")
const objetoCliente = JSON.parse(clienteEmString)
console.log(objetoCliente)
console.log(typeof (objetoCliente))
