import { autor } from "../models/Autor.js"

class autorController {

    static async listarAutores(req, res) {
        try {
            const listaAutores = await autor.find({}) //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
            res.status(200).json(listaAutores);

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - falha na requisição` })
        }

    }

    static async listarAutorPorId(req, res) {
        try {
            const id = req.params.id;
            const AutoresEncontrado = await autor.findById(id) //find({}) metodo do mongoose que vai se conectar com o banco e vai encontrar e buscar tudo que ta na banco
            res.status(200).json(AutoresEncontrado);

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - falha na requisição do autor` })
        }

    }

    static async cadastroAutores(req, res) {
        try {
            const novoAutores = await autor.create(req.body) //body é o corpo da requisição 
            res.status(201).json({ messe: "criado com sucesso", autor: novoAutores });
        } catch (erro) {
            res.status(500).json({ messe: `${erro.message} - falha ao cadastrar autor` })
        }
    }

    static async atualizarAutor(req, res) {
        try {
            const id = req.params.id;
            await autor.findByIdAndUpdate(id, req.body);
            res.status(200).json({ message: `autor atualizado` });

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - falha na atualização` })
        }

    }

    static async deletarAutor(req, res) {
        try {
            const id = req.params.id;
            await autor.findByIdAndDelete(id);
            res.status(200).send("autor removido com sucesso");

        } catch (erro) {
            res.status(500).json({ message: `${erro.message} - não foi possivel excluir o autor` })
        }

    }
}

export default autorController