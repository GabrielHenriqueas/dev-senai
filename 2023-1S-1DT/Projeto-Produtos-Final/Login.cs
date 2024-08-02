using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos_Final
{
    public class Login
    {
        public Login(bool logado) 
        {
            this.Logado = logado;
   
        }
                public bool Logado { get; set; }
        public Login()
        {
            Usuario user = new Usuario();
            
            string op;
            Console.WriteLine(@$"
                ---------------------------------
                |                               |
                |       [1] - LOGAR             |
                |       [2] - CADASTRAR         |
                |                               |
                |       [0] - SAIR              |
                |                               |
                ---------------------------------
            ");
            
            op = Console.ReadLine();
            
            do
            {
            switch (op)
            {
                case "1":
                    
                    break;
            
                case "2":
                    user.Cadastrar();
                    break;
                
                default:
                    Console.WriteLine($"ENTRADA INVÁLIDA. TENTE NOVAMENTE");
                    break;
            }
            }while(op != "0");
        }

        public void Logar(Usuario user)
        {           
            Console.WriteLine($"Email: ");
            string emailDigitado = Console.ReadLine();
        
            Console.WriteLine($"Senha: ");
            string senhaDigitado = Console.ReadLine();

            foreach (var item in user.usuarios)
            {
                
            }            
        }

        public void Deslogar()
        {

        }       
    }
}