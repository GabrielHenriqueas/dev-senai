using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    //interface ICarrinho
    public interface ICarrinho
    {
        //regras do contrato
        //métodos que deverão ser declarados apenas

        //CRUD : Create, Read, Update, Delete


        //padrão de chamada de métodos
        //tipo Nome(parametros)

        //Create
        void Adicionar(Produto _produto);

        //Read
        void Listar();

        //Update
        void Atualizar(int _codigo, Produto _produto);

        //Delete
        void Remover(Produto _produto);
    }
}