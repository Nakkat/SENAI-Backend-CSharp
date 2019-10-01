using System;
using Exercicio3.Controllers;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoControllers Produto = new ProdutoControllers();

           Produto.CadastrarProduto();
           Produto.ExibirProduto();
           
        }
    }
}
