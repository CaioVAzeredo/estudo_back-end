const alunos = ["João", "Juliana", "Ana", "Caio"];
const medias = [10, 8, 7.5, 9];

const listasDeAlunosEMedias = [alunos, medias]

function exibeNomeENota(aluno) {
    if (listasDeAlunosEMedias[0].includes(aluno)) {
        // const alunos = listasDeAlunosEMedias[0]
        // const medias = listasDeAlunosEMedias[1]

        const [alunos, media] = listasDeAlunosEMedias

        console.log(`${aluno} está cadastrado!`)
        const indice = alunos.indexOf(aluno) //indexOf() mostra o indice de um elemento da array

        const mediaDoAluno = media[indice]
        console.log(`${aluno} tem a media ${mediaDoAluno}`)
/*  */
    } else {
        console.log("aluno nao encontrado ")
    }
}

exibeNomeENota("Caio")