'use strict';
const { Model } = require('sequelize');
const isCpfValido = require('../../utils/validaCpfHelper.js')

module.exports = (sequelize, DataTypes) => {
  class Pessoa extends Model {
    static associate(models) {
      Pessoa.hasMany(models.Curso, {
        foreignKey: 'docente_id'
      });
      Pessoa.hasMany(models.Matricula, {
        foreignKey: 'estudante_id',
        scope: { status: 'matriculado' }, //filtrar apenas por matriculado
        as: 'aulasMatriculadas'
      });
    }
  }
  Pessoa.init({
    nome: {
      type: DataTypes.STRING,
      validate: {
        len: {
          args: [3, 30],
          msg: 'oi'
        }
      }
    },
    email: {
      type: DataTypes.STRING,
      validate: { //validação de email pelo sequelize que faz parte de "validação e limitação" na documentação do sequelize
        isEmail: {
          args: true,
          msg: 'formato do email inválido'
        }
      }
    },
    cpf: {
      type: DataTypes.STRING,
      validate: {
        cpfEhValido: (cpf) => {
          if (!isCpfValido(cpf)) throw new Error('numero de CPF inválido')
        }
      }
    },
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