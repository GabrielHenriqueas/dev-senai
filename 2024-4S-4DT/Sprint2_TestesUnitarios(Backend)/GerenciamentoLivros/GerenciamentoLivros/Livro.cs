using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLivros
{
    public class Livro
    {
        public static List<string> listaLivros {  get; set; } = new List<string>();

        public static string[] AdicionarLivro(string novoLivro);


    }
}
