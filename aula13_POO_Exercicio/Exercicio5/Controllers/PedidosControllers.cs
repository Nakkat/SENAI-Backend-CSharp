using System;
using fic.Desktop.SENAI_Backend_CSharp.aula13_POO_Exercicio.Exercicio5.Models;

namespace fic.Desktop.SENAI_Backend_CSharp.aula13_POO_Exercicio.Exercicio5.Controllers {
    public class PedidosControllers : PizzasControllers {
        PedidoModel Pedido = new PedidoModel ();
        public void ExibirPedido () {
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine("Qual é o endereço da entrega?");
            Pedido.EndereçoDeEntrega = Console.ReadLine();
            System.Console.WriteLine(DateTime.Now.AddMinutes(30));
        }
    }
}