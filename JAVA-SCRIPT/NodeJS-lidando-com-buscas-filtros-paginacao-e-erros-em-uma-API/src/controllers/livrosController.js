import NaoEncotrado from "../erros/NaoEncontrado.js";
import { autores, livros } from "../models/index.js";

class LivroController {

  static listarLivros = async (req, res, next) => {
    try {
      const buscaLivros =  livros.find();

      req.resultado = buscaLivros

      next();
    } catch (erro) {
      next(erro);
    }
  };

  static listarLivroPorId = async (req, res, next) => {
    try {
      const id = req.params.id;

      const livroResultados = await livros.findById(id)
      .populate("autor")

      if (livroResultados !== null) {
        res.status(200).send(livroResultados);
      } else {
        next(new NaoEncotrado("ID do livro nao encontrado"));
      }

    } catch (erro) {
      next(erro);
    }
  };

  static cadastrarLivro = async (req, res, next) => {
    try {
      let livro = new livros(req.body);

      const livroResultado = await livro.save();

      res.status(201).send(livroResultado.toJSON());
    } catch (erro) {
      next(erro);
    }
  };

  static atualizarLivro = async (req, res, next) => {
    try {
      const id = req.params.id;

      const livroResultado = await livros.findByIdAndUpdate(id, { $set: req.body });

      if (livroResultado !== null) {
        res.status(200).send({ message: "Livro atualizado com sucesso" });
      } else {
        next(new NaoEncotrado("ID do livro nao encontrado"));
      }
    } catch (erro) {
      next(erro);
    }
  };

  static excluirLivro = async (req, res, next) => {
    try {
      const id = req.params.id;

      const livroResultado = await livros.findByIdAndDelete(id);

      if (livroResultado !== null) {
        res.status(200).send({ message: "Livro excluido com sucesso" });
      } else {
        next(new NaoEncotrado("ID do livro nao encontrado"));
      }
    } catch (erro) {
      next(erro);
    }
  };

  static listarLivroPorFiltro = async (req, res, next) => {
    try {
      const busca = await processaBusca(req.query);

      if (busca !== null) {
        const livrosResultado = livros
          .find(busca) // serve para pesquisar documentos em uma coleção
          .populate("autor");//é usado para carregar os dados do documento relacionado ao autor do livro.

        req.resultado = livrosResultado
        next();
        
      } else {
        res.status(200).send([]);
      }

    } catch (erro) {
      next(erro);
    }
  };
}

async function processaBusca(parametro) {
  const { editora, titulo, minPaginas, maxPaginas, nomeAutor } = parametro;

  let busca = {};

  if (editora) busca.editora = { $regex: editora, $options: "i" };
  /* ---------------------------------------- */
  if (titulo) busca.titulo = { $regex: titulo, $options: "i" }; // /titulo/i 
  /* ---------------------------------------- */
  if (minPaginas || maxPaginas) busca.numeroPaginas = {}
  /* ---------------------------------------- */
  //gte = Greater Than or Equal = Maior ou igual que
  if (minPaginas) busca.numeroPaginas.$gte = minPaginas;
  //lte = Less The or Equal = Menor ou igual que
  if (maxPaginas) busca.numeroPaginas.$lte = maxPaginas;
  /* ---------------------------------------- */
  if (nomeAutor) {
    const autor = await autores.findOne({ nome: nomeAutor }); //buscando dentro do banco de autores o nome de autor.
    if (autor !== null) {
      busca.autor = autor._id;//"_id" é por estar com salvo no banco de dados dessa forma
    } else {
      busca = null;
    }
  }

  return busca;
}

export default LivroController;