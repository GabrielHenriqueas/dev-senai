using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListasObjetos
{
    public class Produto
    {

        // PROPRIEDADES
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // CONSTRUTORES
        public Produto()
        {

        }

        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }


    }
}