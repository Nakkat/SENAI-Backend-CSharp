using System;
using System.IO;
using Exercicio4.Models;

namespace Exercicio4.Controllers {
    public class CalculadoraCientificaControllers : CalculadoraControllers{
        CalculadoraModel Calculadora = new CalculadoraModel ();
        double resultado;
    

       
        public void Potencia () {
            try {
                System.Console.WriteLine ("Digite a base da sua potência ");
                Calculadora.Dig1 = double.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Digite o expoente: ");
                Calculadora.Dig2 = double.Parse (Console.ReadLine ());
                resultado = Math.Pow (Calculadora.Dig1, Calculadora.Dig2);
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