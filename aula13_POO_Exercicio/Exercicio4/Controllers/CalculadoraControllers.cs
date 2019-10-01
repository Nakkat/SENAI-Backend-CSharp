using System;
using System.IO;
using Exercicio4.Models;

namespace Exercicio4.Controllers {
    public class CalculadoraControllers {
        CalculadoraModel Calculadora = new CalculadoraModel ();
        
        double resultado;
        public void Soma () {
            try {

                System.Console.WriteLine ("Digite o primeiro número para somar: ");
                Calculadora.Dig1 = double.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite o segundo número a ser somado: ");
                Calculadora.Dig2 = double.Parse (Console.ReadLine ());
                resultado = Calculadora.Dig1 + Calculadora.Dig2;
                System.Console.WriteLine ("Seu resultado é: " + resultado);
            } catch (System.Exception ex) {
                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação");
                SalvarErros (ex);
            }
        }

        public void Subtracao () {
            try {
                System.Console.WriteLine ("Digite o primeiro número para subtrair: ");
                Calculadora.Dig1 = double.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite o segundo número: ");
                Calculadora.Dig1 = double.Parse (Console.ReadLine ());
                resultado = Calculadora.Dig1 - Calculadora.Dig2;
                System.Console.WriteLine ("Seu resultado é: " + resultado);

            } catch (System.Exception ex) {

                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação");
                SalvarErros (ex);
            }

        }

        public void Multiplicacao () {
            try {
                System.Console.WriteLine ("Digite o primeiro número para multiplicar ");
                Calculadora.Dig1 = double.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite o segundo número: ");
                Calculadora.Dig2 = double.Parse (Console.ReadLine ());
                resultado = Calculadora.Dig1 * Calculadora.Dig1;
                System.Console.WriteLine ("Seu resultado é: " + resultado);
            } catch (System.Exception ex) {
                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação");
                SalvarErros (ex);
            }
        }

        public void Divisao () {
            try {
                System.Console.WriteLine ("Digite o primeiro número a dividir): ");
                Calculadora.Dig1= double.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite o segundo númemro: ");
                Calculadora.Dig2 = double.Parse (Console.ReadLine ());
                resultado = Calculadora.Dig1 / Calculadora.Dig2;
                System.Console.WriteLine ("Seu resultado é: " + resultado);
            } catch (System.Exception ex) {
                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação");
                SalvarErros (ex);
            }
        }
        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();
        }
    }
}
        

       