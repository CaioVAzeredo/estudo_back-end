'use strict';

const fs = require('fs');
const path = require('path');
const Sequelize = require('sequelize');
const process = require('process');
const basename = path.basename(__filename);

//Verificar qual é o ambiente de execução e as credenciais de acesso ao banco correspondentes. Já existe um código pronto para buscar o ambiente em um arquivo .env ou, na falta dele, assumir que o ambiente a ser utilizado é development:
const env = process.env.NODE_ENV || 'development';
const config = require(__dirname + '/../config/config.json')[env];
const db = {};

//Criar uma nova instância de Sequelize a partir dos dados de conexão:
let sequelize;
if (config.use_env_variable) {
  sequelize = new Sequelize(process.env[config.use_env_variable], config);
} else {
  sequelize = new Sequelize(config.database, config.username, config.password, config);
}
//Percorrer a pasta models, indexar e executar o código de cada modelo dentro da pasta e salvar o objeto resultante na variável db:
fs
  .readdirSync(__dirname)
  .filter(file => {
    return (
      file.indexOf('.') !== 0 &&
      file !== basename &&
      file.slice(-3) === '.js' &&
      file.indexOf('.test.js') === -1
    );
  })
  .forEach(file => {
    const model = require(path.join(__dirname, file))(sequelize, Sequelize.DataTypes);
    db[model.name] = model;
  });

//Indexar quais modelos estão associados entre si e os métodos correspondentes (iremos falar de associações durante este curso):
Object.keys(db).forEach(modelName => {
  if (db[modelName].associate) {
    db[modelName].associate(db);
  }
});

db.sequelize = sequelize;
db.Sequelize = Sequelize;

module.exports = db;
