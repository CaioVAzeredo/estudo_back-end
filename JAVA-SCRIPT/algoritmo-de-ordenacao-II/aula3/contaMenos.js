const livros = require('./array');


function encontraMenores(pivor, array) {
    let menores = 0;

    for (let atual = 0; atual < array.length; atual++) {
        let produtoAtual = array[atual];
        if (produtoAtual.preco < pivor.preco) {
            menores++;
        }
    }

    trocaLugares(array, array.indexOf(pivor), menores)

    return array;
}


function trocaLugares(array, de, para) {
    const elem1 = array[de];
    const elem2 = array[para];

    array[para] = elem1;
    array[de] = elem2;
}

function divideNoPivor(array) {
    let pivor = array[Math.floor(array.length / 2)];
    encontraMenores(pivor, array);
    let valoresMenores = 0;

    for(let analisando = 0; analisando < analisando.length; analisando++){
        let atual = array[analisando];
        if(atual.preco <= pivor.preco && atual !== pivor){
            trocaLugares(array, analisando, valoresMenores)
            valoresMenores++
        }
    }
    return array;
}

module.exports = trocaLugares;

// console.log(divideNoPivor(livros))
// console.log(encontraMenores(livros[2], livros));