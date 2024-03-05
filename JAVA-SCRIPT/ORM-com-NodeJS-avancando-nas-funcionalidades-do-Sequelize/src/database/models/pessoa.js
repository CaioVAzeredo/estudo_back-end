'use strict';
const { Model } = require('sequelize');


module.exports = (sequelize, DataTypes) => {
  class Pessoa extends Model {
    static associate(models) {
      Pessoa.hasMany(models.Curso, {
        foreignKey: 'docente_id'
      });
      Pessoa.hasMany(models.Matricula, {
        foreignKey: 'estudante_id',
        // scope: { status: 'matriculado' },
        as: 'aulasMatriculadas'
      });
    }
  }
  Pessoa.init({
    nome: DataTypes.STRING,
    email: {
      type: DataTypes.STRING,
      validade: { //validação de email pelo sequelize que faz parte de "validação e limitação" na documentação do sequelize
        isEmail: {
          args: true,
          msg: 'FORMATO INVÁLIDO'
        }
      }
    },
    cpf: DataTypes.STRING,
    ativo: DataTypes.BOOLEAN,
    role: DataTypes.STRING
  }, {
    sequelize,
    modelName: 'Pessoa',
    tableName: 'pessoas',
    paranoid: true, //Config de soft delete
    defaultScope: { //Scope padrao é aplicado onde a coluna é ativo sendo igual a true
      where: {
        ativo: true,
      }
    },
    scopes: {
      todosOsRegistros: {
        where: {} //Objeto vasio mostra que nao estamos especificando nada no where, logo ele manda todos os registros
      }
    }
  });
  return Pessoa;
};