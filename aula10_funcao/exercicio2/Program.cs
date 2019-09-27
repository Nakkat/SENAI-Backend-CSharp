using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeDataHora ();
            }
            static void ImprimeDataHora () {
                Console.WriteLine ("O atual dia da semana é: " + DateTime.Now.ToShortDateString ());
        }
    }
}
