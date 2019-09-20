using System;

namespace atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int total = 0;
            int numeros = 1;
           for (int i = 1; i <= 10; i++) {

               Console.WriteLine("Digite um número maior que 0: ");
               n = int.Parse(Console.ReadLine());
                  if(n  > 0) {
                     if(n % 2 != 0){
                         total = total + n;
                     }
                     if (n % 3 == 0){
                         numeros = numeros * n;
                     }
                 }
                 }
                 Console.WriteLine("A soma de todos nº impar é: " + total);
                 Console.WriteLine("todos nº múltiplos de 3 maior que 0 são: " + numeros);
        }
    }
}
