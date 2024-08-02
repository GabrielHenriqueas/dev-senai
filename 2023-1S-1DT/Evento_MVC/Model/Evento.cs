using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evento_MVC.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }

        private const string PATH = "Database/Evento.csv";

        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento e = new Evento();

                e.Nome = atributos[0];
                e.Descricao = atributos[1];
                e.Data = atributos[2];

                eventos.Add(e);
            }

            return eventos;
        }

        public string PrepararLinhasCSV(Evento e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }

        //método para inserir um produto na linha do CSV
        public void Inserir(Evento e)
        {
            //array que armazena as linhas obtidas pelo método PrepararLinhasCSV
            string[] linhas = {PrepararLinhasCSV(e)};

            //inserir todas as linhas no arquivo dentro do PATH
            File.AppendAllLines(PATH, linhas);
        }




    }
}