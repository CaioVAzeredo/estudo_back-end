
function menorValor(arrProduto, posicaoInicial){

    let maisBarato = posicaoInicial;
    
    for (let atual = posicaoInicial; atual < arrProduto.length; atual++) {
        if (arrProduto[atual].preco < arrProduto[maisBarato].preco) {
            maisBarato = atual
        }
    }
    return maisBarato
}


module.exports = menorValor