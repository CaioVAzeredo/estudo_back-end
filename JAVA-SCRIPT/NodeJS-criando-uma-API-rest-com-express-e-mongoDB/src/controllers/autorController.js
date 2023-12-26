import { autor } from "../models/Autor.js";

class autorController {

  static listarAutores = async (req, res, next) => {
    try {
      const autoresResultado = await autor.find(); //find() metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
      res.status(200).json(autoresResultado);
    } catch (erro) {
      next(erro);
    }

  };

  static listarAutorPorId = async (req, res, next) => {
    try {
      const id = req.params.id;
      const AutoresEncontrado = await autor.findById(id); //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
      if (AutoresEncontrado !== null) {
        res.status(200).json(AutoresEncontrado);
      } else {
        res.status(404).json({ message: "falha na requisição do autor" });
      }

    } catch (erro) {
      next(erro);
    }
  };

  static cadastroAutores = async (req, res, next) => {
    try {
      const novoAutores = await autor.create(req.body); //body é o corpo da requisição 
      res.status(201).json({ messe: "criado com sucesso", autor: novoAutores });
    } catch (erro) {
      next(erro);
    }
  };

  static atualizarAutor = async (req, res, next) => {
    try {
      const id = req.params.id;
      await autor.findByIdAndUpdate(id, req.body);
      res.status(200).json({ message: "autor atualizado" });

    } catch (erro) {
      next(erro);
    }

  };

  static deletarAutor = async (req, res, next) => {
    try {
      const id = req.params.id;
      await autor.findByIdAndDelete(id);
      res.status(200).send("autor removido com sucesso");

    } catch (erro) {
      next(erro);
    }

  };
}

export default autorController;