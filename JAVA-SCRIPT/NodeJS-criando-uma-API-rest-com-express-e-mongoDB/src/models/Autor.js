import mongoose from "mongoose";

const autorSchema = new mongoose.Schema({ //Schema é um objeto de configuração que define a estrutura e as propriedades de um documento.

  id: { type: mongoose.Schema.Types.ObjectId },
  nome: { type: String, require: true },
  nacionalidade: { type: String }

}, { versionKey: false });

const autor = mongoose.model("autores", autorSchema);

export { autor, autorSchema };//Modelo é um objeto que representa uma coleção na base de dados