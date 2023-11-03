const user = {
    nome: "Caio",
    email: "c@gmail.com",
    nascimento: "1998/08/23",
    role: "adm",
    ativo: true,
    exibeInfos: function () {
        console.log(this.nome, this.email)
    }
}

const adm = {
    nome: "Joao",
    email: "j@j.com",
    role: "adm",
    criarCurso() {
        console.log('curso criado');
    }
}

Object.setPrototypeOf(adm, user); //primeiro parâmetro: parametro que vai receber algum elemento. segundo paramentro é o que vai doar algum elemento
adm.criarCurso(); // elemento próprio de adm
adm.exibeInfos(); // elemento herdado de user