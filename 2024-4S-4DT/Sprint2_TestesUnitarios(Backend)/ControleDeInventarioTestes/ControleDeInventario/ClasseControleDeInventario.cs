using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeInventario
    {
    public static class ClasseControleDeInventario
        {
        public class Produto
            {
            public string? Nome { get; set; }
            public int Quantidade { get; set; }
            }

        public static List<Produto> ListaProdutos { get; set; } = new List<Produto>();

        public static void AdicionarProduto(string nome)
            {
            var produto = ListaProdutos.FirstOrDefault(x => x.Nome == nome);

            if (produto != null)
                {
                produto.Quantidade++;
                }
            else
                {
                ListaProdutos.Add(new Produto { Nome = nome, Quantidade = 1 });
                }
            }
        public static int ObterQuantidade(string nome)
            {
            if (ListaProdutos.FirstOrDefault(x => x.Nome == nome) == null)
            {
                return 0;
            }
            return ListaProdutos.FirstOrDefault(x => x.Nome == nome)!.Quantidade;
            }
        }
    }
