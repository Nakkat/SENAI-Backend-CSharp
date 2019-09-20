using System;

namespace atividade5 {
    class Program {
        static void Main (string[] args) {
            double salario;
            int func;
            double media;
            double acm = 0;
            int cont = 0;

            Console.WriteLine ("Digite quantos funcionários há na empresa");
            func = int.Parse (Console.ReadLine ());

            do {
                Console.WriteLine ("Digite o salário do funcionário: ");
                salario = double.Parse (Console.ReadLine ());
                acm = acm + salario;
                cont++;
                
            } while (cont <= func);
            media = func * salario;
            Console.WriteLine ("A média de salários é : R$" + media);
        }
    }
}