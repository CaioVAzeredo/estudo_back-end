import express from "express";

// get: pegar
// post: criar
// put: alterar 

//Metodo CRUD = Create, Read, Update, Delete

const app = express();
app.use(express.json()); //middleware -> ter acesso as requisições no momento em que elas estao sendo feitas 
/* ------------------------------------------ */
const livros = [
    {
        id: 1,
        titulo: "HP"
    },
    {
        id: 2,
        titulo: "IT: A coisa"
    }
];

function buscaLivros(id) {
    return livros.findIndex(livro => {
        return livro.id === Number(id);
    });
}
/* ------------------------------------------ */
app.get("/", (req, res) => {
    res.status(200).send("Curso de Node.js");
});

app.get("/livros", (req, res) => {
    res.status(200).json(livros);
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
