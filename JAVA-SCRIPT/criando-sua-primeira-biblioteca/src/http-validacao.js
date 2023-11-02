import chalk from "chalk";

function extraiLinks(arrLinks) {
    return arrLinks.map((objLink) => Object.values(objLink).join());
}
async function checaStatus(listaURLs) {
    const arrStatus = await Promise.all( // pegar todas as promessas pendentes para resolvel-las.
        listaURLs.map(async (url) => {
            try {
                const response = await fetch(url);
                return response.status; //retornar a situação das URLs
            } catch (erro) {
                return manejaErros(erro)
            }
        })
    );
    return arrStatus;
}

function manejaErros(erro) {
    if(erro.cause.code==='ENOTFOUND'){
        return  'link não encontrado';
    }else{
        return 'ocorreu algum erro';
    }
}

export default async function listaValidada(listaDeLinks) {
    const links = extraiLinks(listaDeLinks);
    const status = await checaStatus(links);
    return listaDeLinks.map((objeto, indice) => ({
        ...objeto,
        status: status[indice],
    }))
}

