using System;

namespace fic.Desktop.SENAI_Backend_CSharp.aula13_POO_Exercicio.Exercicio5.Models
{
    public class PedidoModel : PizzaModel
    {
        public DateTime DataPedido {get; set;}
        
        public string EndereçoDeEntrega {get; set;}
        public DateTime PrevisaoEntrega {get; set;}
    }
}