import mongoose, { mongo } from "mongoose";

async function conectaNaDataBase() {
    mongoose.connect("mongodb+srv://admin:admin123@cluster0.iuprf6v.mongodb.net/livraria?retryWrites=true&w=majority")
 
    return mongoose.connection;
}

export default conectaNaDataBase
