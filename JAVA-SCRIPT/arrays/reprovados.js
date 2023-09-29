const alunos = ["Ana", "Marcos", "Maria", "Mauro"]; //0
const medias = [7, 4.5, 8, 7.5]; //1

const reprovados = alunos.filter((alunos, indice) => {

    if (medias[indice] < 8) {
        console.log(`Aluno(a) ${alunos} REPROVADO(A)`)
    }
    //return medias[indice] < 7 //retorna uma array com os reprovados
})