import livro from "../models/livro.js";
import { autor } from "../models/Autor.js";

class livroController {

  static async listarLivros(req, res, next) {
    try {
      const listaLivros = await livro.find({}); //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
      res.status(200).json(listaLivros);

    } catch (erro) {
      next(erro);
    }

  }

  static async listarLivroPorId(req, res, next) {
    try {
      const id = req.params.id;
      const LivroEncontrado = await livro.findById(id); //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
      res.status(200).json(LivroEncontrado);

    } catch (erro) {
      next(erro);
    }

  }

  static async cadastroLivro(req, res, next) {
    const novoLivro = req.body; //body é o corpo da requisição 
    try {
      const autorEncotrado = await autor.findById(novoLivro.autor);
      const livroCompleto = { ...novoLivro, autor: { ...autorEncotrado._doc } };
      const livroCriado = await livro.create(livroCompleto);


      res.status(201).json({ messe: "criado com sucesso", livro: livroCriado });
    } catch (erro) {
      next(erro);
    }
  }

  static async atualizarLivro(req, res, next) {
    try {
      const id = req.params.id;
      await livro.findByIdAndUpdate(id, req.body);
      res.status(200).json({ message: "livro atualizado" });

    } catch (erro) {
      next(erro);
    }

  }

  static async deletarLivro(req, res, next) {
    try {
      const id = req.params.id;
      await livro.findByIdAndDelete(id);
      res.status(200).send("livro removido com sucesso");

    } catch (erro) {
      next(erro);
    }

  }

  static async listarLivrosPorEditora(req, res, next) {
    const editora = req.query.editora;
    try {
      const livrosPorEditora = await livro.find({ editora: editora }); //chave se refere a propriedade editora e o valor é a variavel que está guardando a informação que vai chegar via rota.
      res.status(200).json(livrosPorEditora);
    } catch (erro) {
      next(erro);
    }
  }
}

export default livroController;