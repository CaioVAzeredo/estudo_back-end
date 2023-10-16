const livros = require('./livros')
const menorValorTrazido = require('./menorValor')

for (let atual = 0; atual < livros.length; atual++) {
    let menor = menorValorTrazido(livros, atual)

    let livroAtual = livros[atual]
    console.log("posiçao atual: " + atual)
    console.log("livro atual: ", livros[atual])
    let livroMenorPreco = livros[menor]
    console.log("livro menor: ", livros[menor])


    livros[atual] = livroMenorPreco
    livros[menor] = livroAtual
}

console.log(livros)



