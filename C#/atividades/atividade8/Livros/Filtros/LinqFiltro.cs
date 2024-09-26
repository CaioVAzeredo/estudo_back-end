using Livros.Models;

namespace Livros.Filtros;

internal class LinqFiltros{
    public static void FiltrarLivros(List<Livro> livros){
  
        var livrosOrdenados = livros
        .Where(livro => livro.Ano_publicacao >= 1950) //Filtra uma coleção com base em uma condição fornecida. Apenas os elementos que satisfazem essa condição serão incluídos na coleção resultante.
        .OrderBy(livro => livro.Titulo)//Ordena uma coleção em ordem crescente com base em uma chave fornecida. A chave pode ser uma propriedade ou uma função que retorna o valor pelo qual a ordenação deve ser feita.
        .ToList();//Converte a coleção resultante de uma consulta LINQ em uma lista (List<T>). Isso é útil para materializar a consulta, ou seja, para armazenar o resultado em uma lista concreta, já que as consultas LINQ são, por padrão, executadas de forma diferida (lazy).

        foreach(var livro in livrosOrdenados){
            Console.WriteLine($"Livro: {livro.Titulo}, Ano de publicação: {livro.Ano_publicacao}");
        }
    }
}