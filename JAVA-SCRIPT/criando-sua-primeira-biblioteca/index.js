import fs from 'fs';
import chalk from 'chalk';

//async/await
async function pegaArquivo(caminhoDoArquivo) {
    try {
        const encoding = 'utf-8';
        const texto = await fs.promises.readFile(caminhoDoArquivo, encoding);
        console.log(extraiLinks(chalk.green(texto)));
    } catch (erro) {
        trataErro(erro);
    }
}


function extraiLinks(texto) {
    const regex = /\[([^[\]]*?)\]\((https?:\/\/[^\s?#.].[^\s]*)\)/gm; //expressão regular
    const capturas = [...texto.matchAll(regex)];
    const resultados = capturas.map(captura => ({ [captura[1]]: captura[2] }))

    return resultados;
}

function trataErro(erro) {
    throw new Error(chalk.red(erro.code, 'Nao há arquivo no diretório'));
}



pegaArquivo('./arquivos/texto.md');


/* --------------------------------------------------------------------------------------- */
//promises com then() - pode ser substituido no lugar de async/await
/* function pegaArquivo(caminhoDoArquivo) {
    const encoding = 'utf-8';
    fs.promises
        .readFile(caminhoDoArquivo, encoding)
        .then((texto) => console.log(chalk.green(texto)))
        .catch(trataErro);
} */