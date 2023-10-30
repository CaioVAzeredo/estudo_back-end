const livros = require('./array');
const trocaLugares = require('./contaMenos')

function quickSort(array, esquerda, direita) {

    if (array.length > 1) {
        let indiceAtual = particiona(array, esquerda, direita)
        if(esquerda < indiceAtual - 1){
            quickSort(array, esquerda, indiceAtual - 1)
        }
        if(indiceAtual < direita){
            quickSort(array, indiceAtual, direita)
        }
    }

    return array;
}


function particiona(array, esquerda, direita) {
    let pivor = array[Math.floor((esquerda + direita) / 2)]
    let atualEsquerda = esquerda;
    let atualDireita = direita;

    while (atualEsquerda <= atualDireita){
        while(array[atualEsquerda].preco < pivor.preco){
            atualEsquerda++;
        }

        while(array[atualDireita].preco > pivor.preco){
            atualDireita--
        }

        if(atualEsquerda <= atualDireita){
            trocaLugares(array, atualEsquerda, atualDireita)
            atualEsquerda++;
            atualDireita--;
        }
    }
    return atualEsquerda;
}


console.log(quickSort(livros, 0, livros.length - 1))