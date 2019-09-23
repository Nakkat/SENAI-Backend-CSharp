using System;

namespace aula4exercicios
{
    class Program
    {
        static void Main(string[] args)
        {  double[] valor = new double[10];
            
           for (int i = 1; i <= 9; i++) {

                Console.WriteLine ("Digite um valor: ");
                valor[i] = double.Parse (Console.ReadLine ());

            }  
            for (int i = 0 ; i < valor.Length; i++){
                Console.WriteLine("Valores : " + valor[i]);
            }
             Console.WriteLine (valor[9] * 5);
        }
    }
}
