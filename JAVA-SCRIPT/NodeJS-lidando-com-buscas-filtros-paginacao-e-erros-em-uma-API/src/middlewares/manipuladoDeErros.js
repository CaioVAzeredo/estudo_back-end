/* eslint-disable no-unused-vars */
import mongoose from "mongoose";

function manipuladorDeErro(erro, req, res, next) {
  if (erro instanceof mongoose.Error.CastError) {
    res.status(400).send({ message: " Um ou mais dados fornecidos estão incorretos" });
  } else if (erro instanceof mongoose.Error.ValidationError) {
    res.status(400).send({ message: "Houve um erro de validação de dados" });
  } else {
    res.status(500).send({ message: "Erro interno no servidor" });
  }
}

export default manipuladorDeErro;