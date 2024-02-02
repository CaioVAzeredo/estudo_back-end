import mongoose from "mongoose";
import mongooseAutoPopulate from "mongoose-autopopulate";

const livroSchema = new mongoose.Schema(
  {
    id: { type: String },
    titulo: {
      type: String, required: [true, "O título é obrigatório"]
    },
    autor: {
      type: mongoose.Schema.Types.ObjectId,
      ref: "autores",
      required: [true, "O autor é obrigatório"],
      autoPopulate: true //Isso irá indicar para o plugin que esse é o campo a ser populado automaticamente sempre que formos obter um ou mais livros.
    },
    editora: {
      type: String, required: [true, "A editora é obrigatório"],
      enum: {
        values: ["Casa do codigo", "Alura"],
        message: "A editora {VALUE} não é um valor permitido"
      }
    },
    numeroPaginas: {
      type: Number,
      validate: {
        validator: (valor) => {
          return valor >= 10 && valor <= 5000;
        },
        message: "O numero de pag deve ser entre 10 e 5000. Valor fornecido {VALUE} não é permitido "
      }
    }
  }
);

const livros = mongoose.model("livros", livroSchema);
livroSchema.plugin(mongooseAutoPopulate) //Nao deu certo

export default livros;