/* fazer um objeto Produto com nome e quantidade, fazer um dictionary com estoque */
using Atividade2.Modelos;

Produto caneta = new Produto("caneta", 2);

Dictionary<int, Produto> produtosRegistrados = new();
produtosRegistrados.Add(caneta.Quantidade, caneta);