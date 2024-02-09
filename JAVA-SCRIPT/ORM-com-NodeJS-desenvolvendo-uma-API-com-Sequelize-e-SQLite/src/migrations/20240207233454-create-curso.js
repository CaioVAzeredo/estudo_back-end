'use strict';
/** @type {import('sequelize-cli').Migration} */
module.exports = {
  async up(queryInterface, Sequelize) {
    await queryInterface.createTable('cursos', {
      id: {
        allowNull: false,
        autoIncrement: true,
        primaryKey: true,
        type: Sequelize.INTEGER
      },
      titulo: {
        type: Sequelize.STRING
      },
      descricao: {
        type: Sequelize.STRING
      },
      data_inicio: {
        type: Sequelize.DATEONLY
      },
      /* ----------------------------------------------- */
      docente_id: { //tem que ser o mesmo nome da tabela
        allowNull: false,
        type: Sequelize.INTEGER,
        references: { model: 'pessoas', key: 'id' } //model recebe o nome da tabela do BD
      },
      /* ----------------------------------------------- */
      docente_id: { //tem que ser o mesmo nome da tabela
        allowNull: false,
        type: Sequelize.INTEGER,
        references: { model: 'categorias', key: 'id' } //model recebe o nome da tabela do BD
      },
      /* ----------------------------------------------- */

      createdAt: {
        allowNull: false,
        type: Sequelize.DATE
      },
      updatedAt: {
        allowNull: false,
        type: Sequelize.DATE
      }
    });
  },
  async down(queryInterface, Sequelize) {
    await queryInterface.dropTable('cursos');
  }
};