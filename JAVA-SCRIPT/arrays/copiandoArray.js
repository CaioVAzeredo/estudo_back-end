const notas = [7, 7, 8, 9];

const novasNotas = [...notas] //[5, ...notas, 10]

novasNotas.push(10)
notas.push(5)

console.log(`novas notas ${novasNotas}`)
console.log(`antigas notas ${notas}`)