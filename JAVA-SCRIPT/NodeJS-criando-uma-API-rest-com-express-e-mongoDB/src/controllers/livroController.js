import livro from "../models/livro.js"
import { autor } from "../models/Autor.js";

class livroController {

    static async listarLivros(req, res) {
        try {
            const listaLivros = await livro.find({}) //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
            res.status(200).json(listaLivros);

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - falha na requisição` })
        }

    }

    static async listarLivroPorId(req, res) {
        try {
            const id = req.params.id;
            const LivroEncontrado = await livro.findById(id) //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
            res.status(200).json(LivroEncontrado);

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - falha na requisição do livro` })
        }

    }

    static async cadastroLivro(req, res) {
        const novoLivro = req.body //body é o corpo da requisição 
        try {
            const autorEncotrado = await autor.findById(novoLivro.autor);
            const livroCompleto = { ...novoLivro, autor: { ...autorEncotrado._doc } }
            const livroCriado = await livro.create(livroCompleto);


            res.status(201).json({ messe: "criado com sucesso", livro: livroCriado });
        } catch (erro) {
            res.status(500).json({ messe: `${erro.message} - falha ao cadastrar livro` })
        }
    }

    static async atualizarLivro(req, res) {
        try {
            const id = req.params.id;
            await livro.findByIdAndUpdate(id, req.body);
            res.status(200).json({ message: `livro atualizado` });

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - falha na atualização` })
        }

    }

    static async deletarLivro(req, res) {
        try {
            const id = req.params.id;
            await livro.findByIdAndDelete(id);
            res.status(200).send("livro removido com sucesso");

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - não foi possivel excluir o livro` })
        }

    }

    static async listarLivrosPorEditora(req, res) {
        const editora = req.query.editora;
        try {
            const livrosPorEditora = await livro.find({ editora: editora }); //chave se refere a propriedade editora e o valor é a variavel que está guardando a informação que vai chegar via rota.
            res.status(200).json(livrosPorEditora);
        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - falha na busca` });
        }
    }
}

export default livroController