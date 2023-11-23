import mongoose, {mongo} from "mongoose";

async function conectaNaDataBase() {
    mongoose.connect(process.env.DB_CONNECTION_STRING) //acessar a URL através do env

    return mongoose.connection;
}

export default conectaNaDataBase;
