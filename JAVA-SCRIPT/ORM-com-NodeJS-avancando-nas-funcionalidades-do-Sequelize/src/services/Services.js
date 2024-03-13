const dataSource = require('../database/models/index.js');

class Services {
  constructor(nomeDoModel) {
    this.model = nomeDoModel;
  }

  async pegaTodosOsRegistros() {
    return dataSource[this.model].findAll();
  }

  async pegaRegistrosPorEscopo(escopo) {
    return dataSource[this.model].scope(escopo).findAll()
  }
  
  async pegaUmRegistroPorId(id) {
    return dataSource[this.model].findByPk(id); //Só aceita a chave primária
  }

  async pegaUmRegistro(where) {
    return dataSource[this.model].findOne({where: {...where}}); //spread operator. Retorna a primeira ocorrencia  que encontrar na coluna mesmo se encontrar nenhuma especificação válida
  }


  async criaRegistro(dadosDoRegistro) {
    return dataSource[this.model].create(dadosDoRegistro);
  }

  async atualizaRegistro(dadosAtualizados, where) {
    const listadeRegistrosAtualizados = await dataSource[this.model].update(dadosAtualizados, {
      where: { ...where }
    });
    if (listadeRegistrosAtualizados[0] === 0) {
      return false;
    }
    return true;
  }

  async excluiRegistro(id) {
    return dataSource[this.model].destroy({ where: { id: id } });
  }
}

module.exports = Services;
