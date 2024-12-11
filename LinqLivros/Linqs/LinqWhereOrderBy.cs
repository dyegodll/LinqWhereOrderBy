using LinqLivros.Models;

namespace LinqLivros.Linqs
{
    internal class LinqWhereOrderBy
    {
        public static void LinqLivroWhereOrderBy(List<Livro> livros) 
        {
            
            var livros_2018_Ordenados = livros.Where(l => l.Ano >= 2018).OrderBy(l => l.Titulo);

            foreach (var livro in livros_2018_Ordenados)
            {

                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}");
            }
        
        }
    }
}
