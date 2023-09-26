// var

var altura = 5
var comprimento = 7

var area = altura * comprimento
console.log(area)


/* let */
/* tem que ser declarado sempre antes  */
let formaLET = 'retangulo'
let alturaLET = 5
let comprimentoLET = 10
let areaLET = alturaLET * comprimentoLET //

if (formaLET === 'retangulo') {
    areaLET = altura * comprimento
} else {
    areaLET = (altura * comprimento) / 2
}


console.log(areaLET)


/* const */
/* nao pode ser alterado o valor, o valor sempre é constante */
const fomra = 'triangulo'
const alturaCONST = 5
const comprimentoCONST = 7
let areaCONST = 0; //se for const, da erro

if(fomra === 'triangulo'){
    areaCONST = altura * comprimento
}else {
    areaCONST = (altura * comprimento) / 2
}

console.log(areaCONST)