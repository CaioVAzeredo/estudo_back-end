import fs from 'fs';
import chalk from 'chalk';

function trataErro(erro) {
    console.log(erro);
    throw new Error(chalk.red(erro.code, 'Nao há arquivo no diretório'));

}

//async/await

function pegaArquivo(caminhoDoArquivo){
    
}


//promises com then()

/* function pegaArquivo(caminhoDoArquivo) {
    const encoding = 'utf-8';
    fs.promises
        .readFile(caminhoDoArquivo, encoding)
        .then((texto) => console.log(chalk.green(texto)))
        .catch(trataErro);
} */


pegaArquivo('./arquivos/');