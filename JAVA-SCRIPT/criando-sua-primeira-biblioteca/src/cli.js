import chalk from 'chalk';
import fs from 'fs';
import pegaArquivo from './index.js';
import listaValidada from './http-validacao.js';

const caminho = process.argv; //Um Array que está armazenando argumentos de linha de comando 

async function processaTexto(argumento) {
    const caminho = argumento[2];
    const valida = argumento[3] === '--valida';

    try {
        fs.lstatSync(caminho);//obter informações sobre um arquivo ou diretório no sistema de arquivos
    } catch (erro) {
        if (erro.code === 'ENOENT') {
            console.log(chalk.red('arquivo ou diretório não existe'));
            return
        }
    }

    if (fs.lstatSync(caminho).isFile()) { //se a informação do caminho for um arquivo
        const resultado = await pegaArquivo(argumento[2]); // leva o arquivo para ser tratado //passando como argumento a terceira posição do array
        imprimeLista(valida, resultado); // resultado do tratamento do resultado 
    } else if (fs.lstatSync(caminho).isDirectory()) { // se a informação do caminho for um diretório
        const arquivos = await fs.promises.readdir(caminho); // vai ler o diretório(.readdir()) colocado como argumento como uma promessa e retornar em uma array

        arquivos.forEach(async (nomeDeArquivo) => { // percorrer pela array 
            const lista = await pegaArquivo(`${caminho}/${nomeDeArquivo}`);// leva o arquivo para ser tratado
            imprimeLista(nomeDeArquivo, valida, lista); // resultado do tratamento do resultado 
        })
    }
}

function imprimeLista(nomeDeArquivo = '', valida, resultado) {

    if (valida) {
        console.log(chalk.yellow(`Lista validada`), listaValidada(resultado));

    } else {
        console.log(chalk.yellow(`Lista de links`), chalk.black.bgGreen(nomeDeArquivo), resultado);
    }
}



processaTexto(caminho)