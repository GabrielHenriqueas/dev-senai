using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        //instância das classes produto e produtoView
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //chamada da model trazendo a lista
            List<Produto> produtos = produto.Ler();
            
            //chamada da view passando a lista
            produtoView.Listar(produtos);
        }

        public void CadastrarProdutos()
        {
            //produto.Inserir(produtoView.Cadastrar());

            Produto novoProduto = produtoView.Cadastrar();
            produto.Inserir(novoProduto);
        }
    }
}