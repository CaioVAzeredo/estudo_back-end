using atividade3.Filmes;

Filmes filme1 = new(50,"Deadpool");
filme1.AdicionaElenco(new Artistas("Ryan Raynolds", 47));
filme1.AdicionaElenco(new Artistas("Morena Baccarin", 45));



filme1.MostrarDetalhes();
