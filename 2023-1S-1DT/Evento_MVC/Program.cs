using Evento_MVC.Controller;
using Evento_MVC.Model;

Evento e = new Evento();

EventoController controller = new EventoController();

controller.CadastrarEventos();
controller.ListarEventos();