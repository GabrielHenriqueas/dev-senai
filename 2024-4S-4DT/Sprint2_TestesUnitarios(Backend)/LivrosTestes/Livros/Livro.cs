namespace Livros
    {
    public class Livro
        {
        public static List<string>? ListaLivros { get; set; } = new List<string>();

        public static string[] AdicionarLivro(string novoLivro)
            {
            ListaLivros!.Add(novoLivro);
            return ListaLivros!.ToArray();
            }
        }
    }
