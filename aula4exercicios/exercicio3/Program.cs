using System;

namespace exercicio3 {
    class Program {
        static void Main (string[] args) {

            string[] nome= new string[12];
            string[] cor= new string[12];
            string[] tamanho= new string[12];
            string[] preco= new string[12];

            for (int i = 0; i <= 2; i++) {

                Console.WriteLine ("Digite o nome do produto: ");
                nome[i] = (Console.ReadLine ());
                Console.WriteLine ("Digite o a cor do produto: ");
                cor[i] = (Console.ReadLine ());
                Console.WriteLine ("Digite o tamanho do produto: ");
                tamanho[i] = (Console.ReadLine ());
                Console.WriteLine ("Digite o preço do produto: ");
                preco[i] = (Console.ReadLine ());
            }
            for (int i = 0; i <= 2; i++) {
                Console.WriteLine (nome[i]);
                Console.WriteLine (cor[i]);
                Console.WriteLine (tamanho[i]);
                Console.WriteLine (preco[i]);
                Console.WriteLine();

            }
        }
    }
}