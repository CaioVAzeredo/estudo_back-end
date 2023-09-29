const notas = [10, 6.5, 8, 7.5];

let soma = 0

for (i = 0; i < notas.length; i++) {
    soma += notas[i]
}
console.log(`A média é: ${soma / notas.length}`)