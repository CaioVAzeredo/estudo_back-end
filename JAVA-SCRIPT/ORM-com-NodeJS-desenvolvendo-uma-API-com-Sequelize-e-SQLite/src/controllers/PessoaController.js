/* Controller é responsavel por gerenciar as requisições e respostas  */
const Controller = require('./Controller.js');
const PessoaServices = require('../services/PessoaServices.js');

const pessoaServices = new PessoaServices()

class PessoaController extends Controller {
    constructor() {
        super(pessoaServices)
    }
}

module.exports = PessoaController;