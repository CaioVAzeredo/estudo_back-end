import mongoose, { mongo } from "mongoose";

async function conectaNaDatabase() {
    mongoose.connect("mongodb+srv://livrariaCaio:caio123@cluster0.ran7iul.mongodb.net/livraria?retryWrites=true&w=majority") //acessar a URL através do env 

    return mongoose.connection;
}

export default conectaNaDatabase;

