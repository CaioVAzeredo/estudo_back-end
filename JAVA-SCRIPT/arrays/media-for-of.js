const notas = [10, 6.5, 8, 7.5];

let soma = 0
for (let elementos of notas) {
    soma += elementos
}

console.log(soma / notas.length)