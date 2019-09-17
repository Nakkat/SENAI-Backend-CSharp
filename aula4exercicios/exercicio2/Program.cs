using System;

namespace exercicio2 {
    class Program {
        static void Main (string[] args) {
            string resultado;
            double pesoterra, peso;
            int num;

            Console.WriteLine ("Digite seu peso: ");
            pesoterra = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Agora, digite seu número: ");
            num = int.Parse (Console.ReadLine ());

            switch (num) {

                case 1:
                    peso = pesoterra / 10 * 0.37;
                    resultado = "Seu peso em Mercúrio é" + peso;
                    break;

                case 2:
                    peso = pesoterra / 10 * 0.88;
                    resultado = "Seu peso em Vênus é: " + peso;;
                    break;

                case 3:
                    peso = pesoterra / 10 * 0.38;
                    resultado = "Seu peso em Marte é: " + peso;;
                    break;

                case 4:
                    peso = pesoterra / 10 * 2.64;
                    resultado = "Seu peso em Júpiter é: " + peso;;
                    break;

                case 5:
                    peso = pesoterra / 10 * 1.15;
                    resultado = "Seu peso em Saturno é: " + peso;;
                    break;

                case 6:
                    peso = pesoterra / 10 * 1.17;
                    resultado = "Seu peso em Urano é: " + peso;;
                    break;

                default:
                    resultado = "Opção inválida";
                    break;

            }

            Console.WriteLine (resultado);
        }
    }
}