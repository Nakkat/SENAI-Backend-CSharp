using System;
using Exercicio2.Controllers;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularControllers Celular = new CelularControllers();

            Celular.Ligar();
            Celular.Ligacao();
            Celular.Mensagem();
            Celular.Desligar();
            Celular.Ligacao();

            


            
        }
    }
}
