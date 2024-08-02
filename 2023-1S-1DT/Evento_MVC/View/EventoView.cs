using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Evento_MVC.Model;

namespace Evento_MVC.View
{
    public class EventoView
    {
        //método para exibir os dados da lista no console

        public void Listar(List<Evento> evento)
        {
            foreach (var item in evento)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Descrição: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data}\n");
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o Nome do Evento: ");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a Descrição: ");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a Data: ");
            novoEvento.Data = Console.ReadLine();

            return novoEvento;
        }
    }
}