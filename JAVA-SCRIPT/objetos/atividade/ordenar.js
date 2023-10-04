const cliente = require("./AtividadeCliente.json")

function ordenar(lista, propriedade) {
    return lista.sort((a, b) => { //ordena na ordem alfabetica(nessa situação)
        if (a[propriedade] < b[propriedade]) {
            return -1
        }
        if (a[propriedade] > b[propriedade]) {
            return 1
        }
        return 0
    })

}


console.log(ordenar(cliente, "nome"))

/* PARA ORDENAR DE TRÁS PARA FRENTE */
console.log(ordenar(cliente, "nome").reverse())

