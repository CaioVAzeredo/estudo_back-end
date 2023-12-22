import express from "express";
import conectaNaDatabase from "./config/dbConnect.js";
import routes from "./routes/index.js";
// get: pegar
// post: criar
// put: alterar 

//Metodo CRUD = Create, Read, Update, Delete

/* -------------------------------------------- */
const conexao = await conectaNaDatabase();

conexao.on("error", (erro) => { //esperar algum tipo de evento de erro da conexao do banco no arquivo dbConnect.js
    console.error("erro de conexão", erro);
})

conexao.once("open", () => {
    console.log("Conexao com o banco feita com sucesso");
}) //espera de um evento de conexao feita com sucesso 
/* -------------------------------------------- */

const app = express();
routes(app);


export default app;
