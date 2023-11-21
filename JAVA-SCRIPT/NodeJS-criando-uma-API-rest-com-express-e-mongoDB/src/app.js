import express from "express";

const app = express();
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
export default app;