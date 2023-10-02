const cliente = {
    nome: "Andre",
    idade: 32,
    cpf: "123132156456",
    email: "kjsdabnkahsbd@ajsndkjasbndk.com"
}

console.log(`O nome do cliente: ${cliente["nome"]} com idade ${cliente["idade"]} anos`)

const chaves = ["nome", "idade", "cpf", "email"]

chaves.forEach(chave => console.log(`A chave ${chave} tem valor ${cliente[chave]}`) )