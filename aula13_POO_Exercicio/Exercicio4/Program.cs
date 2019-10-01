using System;
using Exercicio4.Controllers;

namespace Exercicio4 {
    class Program {
        static void Main (string[] args) {
            CalculadoraCientificaControllers Calculadora = new CalculadoraCientificaControllers ();

            string sair = "";

            Console.WriteLine ("Bem vindo a nossa calculadora!");

            while (sair != "0") {

                Console.WriteLine (
                    @"
                    Menu:
                    1 - Soma
                    2 - Sutração
                    3 - Multiplicação
                    4 - Divisão
                    5 - Potência
                    0 - Sair");

                sair = Console.ReadLine ();

                switch (sair) {
                    case "1":
                         
                            Calculadora.Soma ();
                        
                    break;
                    case "2":
                         
                            Calculadora.Subtracao();
                        
                    break;
                    case "3":
                         
                            Calculadora.Multiplicacao ();
                        
                    break;
                    case "4":
                    
                            Calculadora.Divisao ();
                        
                    break;
                    case "5":
                        
                            Calculadora.Potencia();
                        
                    break;

                }
            }

        }
    }
}