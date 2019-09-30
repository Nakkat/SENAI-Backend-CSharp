using System;
using aula10_POO.Controllers;

namespace aula10POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProdutosController produto1 = new ProdutosController();

            produto1.CadastrarProduto();
            produto1.ExibirProduto();
        }
    }
}
