import mongoose from "mongoose";

const livroSchema = new mongoose.Schema({ //Schema é um objeto de configuração que define a estrutura e as propriedades de um documento.

    id: { type: mongoose.Schema.Types.ObjectId },
    titulo: { type: String, required: true },
    editora: { type: String },
    preco: { type: Number },
    paginas: { type: Number },

}, { versionKey: false });

const livro = mongoose.model("livros", livroSchema);

export default livro;//Modelo é um objeto que representa uma coleção na base de dados
