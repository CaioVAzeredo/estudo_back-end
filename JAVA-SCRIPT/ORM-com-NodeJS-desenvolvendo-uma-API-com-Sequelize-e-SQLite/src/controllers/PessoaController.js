/* Controller é responsavel por gerenciar as requisições e respostas  */
const database = require('../models')
class PessoaController {
    static async pegaTodas(req, res) {
        try {
            const listaDePessoas = await database.Pessoa.findAll();
            return res.status(200).json(listaDePessoas)
        } catch (erro) {

        }
    }
}


module.exports = PessoaController;