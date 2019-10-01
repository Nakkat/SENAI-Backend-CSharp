using System;
using fic.Desktop.SENAI_Backend_CSharp.aula13_POO_Exercicio.Exercicio5.Controllers;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            PedidosControllers Pizza = new PedidosControllers();
           
            Pizza.CadastrarPizza ();
            Pizza.ExibirPizza();
            Pizza.ExibirPedido();
            
        }
    }
}
