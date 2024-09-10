/* fazer um objeto Produto com nome e quantidade, fazer um dictionary com estoque */
using Atividade2.Menu;
using Atividade2.Modelos;

Produto caneta = new Produto("Caneta", 2);
Produto lapis = new("Lapis", 10);

Dictionary<int, Produto> estoque = new();
estoque.Add(1, caneta);
estoque.Add(2, lapis);

Menu ExibirDetalhes = new MenuExibirDetales();
ExibirDetalhes.Executar(estoque);