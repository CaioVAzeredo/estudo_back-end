const cliente = {
    nome: "joao",
    idade: "24",
    email: "joao@firma.com",
    telefone: ["11 0988908890", "11 983712893"],
    saldo: 200,
    efetuaPagamento: function(valor){
        if(valor > this.saldo){
            console.log('saldo insuficiente')
        }else{
            this.saldo -= valor
            console.log(`Pagamento realizado. Novo saldo: ${this.saldo}`)
        }
    }
}

cliente.efetuaPagamento(20)