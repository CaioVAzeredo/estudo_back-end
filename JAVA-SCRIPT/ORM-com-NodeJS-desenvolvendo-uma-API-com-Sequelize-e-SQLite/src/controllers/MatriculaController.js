/* Controller é responsavel por gerenciar as requisições e respostas  */
const Controller = require('./Controller.js');
const MatriculaServices = require('../services/MatriculaServices.js');

const matriculaServices = new MatriculaServices()

class MatriculaController extends Controller {
    constructor() {
        super(matriculaServices)
    }
}

module.exports = MatriculaController;