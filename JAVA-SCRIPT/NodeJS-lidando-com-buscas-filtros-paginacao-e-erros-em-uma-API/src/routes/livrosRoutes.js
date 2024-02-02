import express from "express";
import LivroController from "../controllers/livrosController.js";
import paginar from "../middlewares/paginar.js";

const router = express.Router();

router.get("/livros", LivroController.listarLivros, paginar);
router.get("/livros/busca", LivroController.listarLivroPorFiltro, paginar);
router.get("/livros/:id", LivroController.listarLivroPorId);
router.post("/livros", LivroController.cadastrarLivro);
router.put("/livros/:id", LivroController.atualizarLivro);
router.delete("/livros/:id", LivroController.excluirLivro);

export default router;   