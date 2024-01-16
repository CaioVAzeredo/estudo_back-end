const express = require('express');

const app = express();

app.use(express.json());
app.get('/', (req, res) => {
    res
        .status(200)
        .send({ mensagem: 'Server Online' });
});

app.get('/teste', (req, res) => {
    res
        .status(200)
        .send({ mensagem: 'Boas-vindas à API' });
});

module.exports = app;