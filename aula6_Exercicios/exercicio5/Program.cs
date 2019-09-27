using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] v1 = {1, 2, 3, 4, 5, 6};
            Console.WriteLine("O valor total é: " + ValorTotal(v1));
        }

        static double ValorTotal (double[] v1) {
            double resultado = 0;
            for (int i = 0; i < v1.Length; i++) {
                resultado = resultado + v1[i];
            }
                return resultado;
            }
        }
    }

