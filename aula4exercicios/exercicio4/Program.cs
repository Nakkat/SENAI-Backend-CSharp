using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor1 = new string[15];
            string[] vetor2 = new string[15];
            string[] vetor3 = new string[30];

            for (int i = 0; i <= 14; i++) {

                Console.WriteLine ("Digite uma palavra: ");
                vetor1[i] = (Console.ReadLine ());
            }

            for (int i = 0; i <= 14; i++) {
                Console.WriteLine ("Digite uma palavra: ");
                vetor2[i] = (Console.ReadLine ());

            }

            for (int i = 0; i <= 14; i++) {
                vetor3[i] = vetor1[i];

            }
                for (int i = 0; i <= 14; i++) {
                    vetor3[i+15] = vetor2[i];
                }
                 for (int i = 0; i <= 29; i++) {
                Console.WriteLine (vetor3[i]);
                 }
        }
    }
}
        
    

