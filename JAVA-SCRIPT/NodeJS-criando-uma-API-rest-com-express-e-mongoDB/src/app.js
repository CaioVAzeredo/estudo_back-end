import express from "express";
import conectaNaDataBase from "./config/dbConnetct.js";
import livro from "./models/livro.js";

// get: pegar
// post: criar
// put: alterar 

//Metodo CRUD = Create, Read, Update, Delete

const conexao = await conectaNaDataBase();

conexao.on("error", (erro) => { //esperar algum tipo de evento de erro da conexao do banco no arquivo dbConnect.js
    console.error("erro de conexão", erro);
})

conexao.once("open", () => {
console.log("Conexao com o banco feita com sucesso");
}) //espera de um evento de conexao feita com sucesso 

const app = express();
app.use(express.json()); //middleware -> ter acesso as requisições no momento em que elas estao sendo feitas 
/* ------------------------------------------ */
app.get("/", (req, res) => {
    res.status(200).send("Curso de Node.js");
});

app.get("/livros", async (req, res) => {
    const listaLivros = await livro.find({}) //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
    res.status(200).json(listaLivros);
});

app.get("/livros/:id", (req, res) => {
    const index = buscaLivros(req.params.id);
    res.status(200).json(livros[index])
})
/* ------------------------------------------ */
app.post("/livros", (req, res) => {
    livros.push(req.body);
    res.status(201).send("livro cadastrado com sucesso!") // 201 -> codigo de status http de registro enviado 
})
/* ------------------------------------------ */
app.put("/livros/:id", (req, res) => {
    const index = buscaLivros(req.params.id);
    livros[index].titulo = req.body.titulo;
    res.status(200).json(livros); // json() retorna um objeto
})
/* ------------------------------------------ */
app.delete("/livros/:id", (req, res) => {
    const index = buscaLivros(req.params.id);
    livros.splice(index, 1);
    res.status(200).send("Livro removido com sucesso");
})

export default app;

