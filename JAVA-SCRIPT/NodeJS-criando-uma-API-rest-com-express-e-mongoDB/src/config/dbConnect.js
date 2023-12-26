import mongoose from "mongoose";

async function conectaNaDatabase() {
  mongoose.connect(process.env.DB_CONNECTION_STRING); //acessar a URL através do env 

  return mongoose.connection;
}

export default conectaNaDatabase;

