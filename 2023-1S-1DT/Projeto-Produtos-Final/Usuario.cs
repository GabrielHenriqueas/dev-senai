using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos_Final
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro = DateTime.Now;

        List<Usuario> usuarios = new List<Usuario>();

        public void Cadastrar()
        {
            Usuario user = new Usuario();
            
            Console.WriteLine($"Qual é o codigo do usuário que deseja cadastrar? ");
            user.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Qual é o nome do usuário que deseja cadastrar? ");
            user.Nome = Console.ReadLine();
            
            Console.WriteLine($"Qual é o email do usuário que deseja cadastrar? ");
            user.Email = Console.ReadLine();
            
            Console.WriteLine($"Qual é o senha do usuário que deseja cadastrar? ");
            user.Senha = Console.ReadLine();

            user.DataCadastro = DateTime.Now;

            usuarios.Add(user);
        }
        
        public void Deletar(string email)
        {
            Console.WriteLine($"Qual é o código do usuário você deseja excluir? ");
            email = Console.ReadLine();
            Usuario user = usuarios.Find(x => x.Email == email);
            usuarios.Remove(user);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"USUÁRIO EXCLUIDO COM ÉXITO!");
            Console.ResetColor();
        }
    }
}