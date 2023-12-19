import express from "express";
import livroController from "../controllers/livroController.js";

const routes = express.Router();

routes.get("/livros", livroController.listarLivros);
routes.get("/livros/:id", livroController.listarLivroPorId);
routes.post("/livros", livroController.cadastroLivro);
routes.put("/livros/:id", livroController.atualizarLivro);
routes.delete("/livros/:id", livroController.deletarLivro)



export default routes;