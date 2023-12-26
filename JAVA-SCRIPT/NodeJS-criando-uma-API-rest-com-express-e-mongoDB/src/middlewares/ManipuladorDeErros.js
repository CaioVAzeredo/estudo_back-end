/* eslint-disable no-unused-vars */
import mongoose from "mongoose";
function manipuladorDeErros(erro, req, res, next) {
  if (erro instanceof mongoose.Error.CastError) {
    res.status(404).json({ message: "Um ou mais dados fornecidos estão incorretos." });
  } else {
    res.status(500).send({ message: "Erro interno do servidor." });
  }

}

export default manipuladorDeErros;
(erro, req, res, next) => {
  if (erro instanceof mongoose.Error.CastError) {
    res.status(404).json({ message: "Um ou mais dados fornecidos estão incorretos." });
  } else {
    res.status(500).send({ message: "Erro interno do servidor." });
  }

};