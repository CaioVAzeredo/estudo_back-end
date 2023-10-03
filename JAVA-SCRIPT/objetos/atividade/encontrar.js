const clientes = require("./AtividadeCliente.json")



function encontrar(lista, chave, valor) {
    return lista.find(item => item[chave].includes(valor)) // find é usado para encontrar o que tem dentro do que é passado e retorna o que é passado 
    //includes é mais eficiente que a comparação "===" por conseguir ver se está na lista. A comparaçção "===" compara se os elementos e pode ser que estejam de formas diferentes 
}

const encontrado = encontrar(clientes, "nome", "Kirby")

const encontrado2 = 

console.log(encontrado)