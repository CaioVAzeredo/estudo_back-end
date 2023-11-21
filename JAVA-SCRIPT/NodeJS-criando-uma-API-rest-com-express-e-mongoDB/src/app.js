import express from "express";

const app = express();
app.use(express.json()); //middleware -> ter acesso as requisições no momento em que elas estao sendo feitas 

const livros = [
    {
        id: 1,
        titulo: "HP"
    },
    {
        id: 2,
        titulo: "IT: A coisa"
    }
]

app.get("/", (req, res) => {
    res.status(200).send("Curso de Node.js");
});

app.get("/livros", (req, res) => {
    res.status(200).json(livros);
});

app.post("/livros", (req, res) =>{
    livros.push(req.body);
    res.status(201).send("livro cadastrado com sucesso!") // 201 -> codigo de status http de registro enviado 
})

export default app;
