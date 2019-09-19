using System;

namespace Aula3 {
    class Program {
        static void Main (string[] args) {
            /*  //Laço contado - For - incremento (+)
             for (int cont2 = 1; cont2 <= 100; cont2++) {

                 //Verificamos se o número é diferente de par 
                 if (cont2 % 2 != 0) {
                     Console.WriteLine ("For 0-100 - " + cont2);
                 }
             }
             // Laço contado - for - decremento (-)
             for (int cont2 = 100; cont2 >= 0; cont2--) {
                 if (cont2 % 2 != 0) {
                     Console.WriteLine ("For 100-0 - " + cont2);
                 }
             }

             //Laço condicional - While

             double acumuladora = 0; //acumuladora é sempre a própria + outra variável
             double nota = 0;
             int cont = 0; //cont sempre pega o cont + uma constante

             string sair = "";

             while (sair != "sim") {

                 Console.Write ("Digite a nota de um aluno: ");
                 nota = double.Parse (Console.ReadLine ());

                 acumuladora += nota; //acumuladora é sempre a própria + outra variável
                 cont++; //cont sempre pega o cont + uma constante

                 Console.Write ("Deseja sair da aplicação? sim/nao: ");
                 sair = Console.ReadLine ().ToLower (); //tolower - deixar tudo minúsculo
             }

             Console.WriteLine ("Média das notas : " + (acumuladora / cont));
              */

            /* PROBLEMA

            Faça um algoritomo que leia 20 números inteiros e acumule apenas os número múltiplos de 3
            */
            int num;
            int acum = 0;
            int cont3 = 0;
            do {
                Console.WriteLine ("Digite 20 números: ");
                num = int.Parse (Console.ReadLine ());
                
                if (num % 3 == 0) {
                    acum += num;
                    cont3++;
                }

            } while (cont3 <= 20);

            Console.WriteLine ("Os números que são múltiplos de 3 são: " + acum);

        }
    }
}