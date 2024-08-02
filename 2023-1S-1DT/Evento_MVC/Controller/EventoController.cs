using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evento_MVC.Model;
using Evento_MVC.View;

namespace Evento_MVC.Controller
{
    public class EventoController
    {
        //instância das classes produto e produtoView
        Evento Evento = new Evento();

        EventoView EventoView = new EventoView();

        //método controlador para acessar a listagem de Eventos
        public void ListarEventos()
        {
            //chamada da model trazendo a lista
            List<Evento> Eventos = Evento.Ler();
            
            //chamada da view passando a lista
            EventoView.Listar(Eventos);
        }

        public void CadastrarEventos()
        {
            //Evento.Inserir(EventoView.Cadastrar());

            Evento novoEvento = EventoView.Cadastrar();
            Evento.Inserir(novoEvento);
        }
    }
}