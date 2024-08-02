using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos_Final
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }  
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        List<Produto> produtos = new List<Produto>();

        public void Cadastrar(Produto _produto)
        {
            Produto produto = new Produto();
            
            Console.WriteLine($"Digite o codigo do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto: ");
            produto.NomeProduto = Console.ReadLine();  
            
            Console.WriteLine($"Digite o preço do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());
        
            produto.DataCadastro = DateTime.Now;

            produtos.Add(produto);
        }

        public void Listar()
        {
            if(produtos.Count > 0)
            {
                foreach (var item in produtos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
                    ========================================================================
                    CÓDIGO: {item.Codigo}
                    NOME PRODUTO: {item.NomeProduto}
                    PREÇO PRODUTO: {item.Preco}
                    DATA DE CADASTRO: {item.DataCadastro}
                    ========================================================================
                    ");
                    Console.ResetColor();
                }
            }

            else
            {
                Console.WriteLine($"NENHUM PRODUTO CADASTRADO.");
            }
        }

        public void Deletar(int codigo)
        {
            Console.WriteLine($"Qual código do produto você deseja excluir?");
            codigo = int.Parse(Console.ReadLine());
            Produto produto = produtos.Find (x => x.Codigo == codigo);
            produtos.Remove(produto);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"PRODUTO EXCLUIDO COM ÉXITO!");
            Console.ResetColor();
        }
    }
}