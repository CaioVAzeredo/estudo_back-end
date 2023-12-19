import livro from "../models/livro.js"

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
        try {
            const novoLivro = await livro.create(req.body) //body é o corpo da requisição 
            res.status(201).json({ messe: "criado com sucesso", livro: novoLivro });
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
}

export default livroController