using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos_Final
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        List<Marca> marcas = new List<Marca>();

        public void Cadastrar()
        {
            Marca marca = new Marca();

            Console.WriteLine($"Digite o codigo da Marca");
            marca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome da Marca");
            marca.NomeMarca = Console.ReadLine();

            marca.DataCadastro = DateTime.Now;

            marcas.Add(marca);
        }

        public void Listar()
        {
            foreach (var item in marcas)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
                    ========================================================================
                    CÓDIGO DA MARCA: {Codigo}
                    NOME DA MARCA: {NomeMarca}
                    DATA DE CADASTRO DA MARCA: {DataCadastro}
                    ========================================================================
                    ");
                    Console.ResetColor();
                }
            
        }

        public void Deletar(int codigo)
        {
            Console.WriteLine($"Qual é o código da marca que deseja deletar?");
            codigo = int.Parse(Console.ReadLine());
            Marca marca = marcas.Find(x => x.Codigo == codigo);
            marcas.Remove(marca);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"MARCA EXCLUIDA COM ÉXITO!");
            Console.ResetColor();
        }

    }
}