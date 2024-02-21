// associação: https://sequelize.org/docs/v6/core-concepts/assocs/
// hasMany: um para muitos

'use strict';
const {
  Model
} = require('sequelize');
module.exports = (sequelize, DataTypes) => {
  class Categoria extends Model {
    static associate(models) {
      Categoria.hasMany(models.Curso, {
        foreignKey: 'categoria_id'
      })
    }
  }
  Categoria.init({
    titulo: DataTypes.STRING
  }, {
    sequelize,
    modelName: 'Categoria',
    tableName: 'categorias'
  });
  return Categoria;
};