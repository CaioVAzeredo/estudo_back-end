function soma(num1, num2) {
    return num1 + num2
}

console.log(soma(5, 10))
console.log(soma(40, 60))
console.log(soma(5, 5))
console.log(soma(10, 10))
/* ------------------------------------------ */
function nomeIdade(nome, idade) {
    return `meu nome é ${nome} e minha idade é ${idade}`
}


console.log(nomeIdade('Caio', '25'))

/* ----------------------------------------- */

function soma(num1, num2) {
    return num1 + num2
}

function multiplica(num1 = 1, num2 = 1) {
    return num1 * num2
}

console.log(multiplica(soma(4, 5)))