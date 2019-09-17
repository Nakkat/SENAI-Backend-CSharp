using System;

namespace exercicio {
    class Program {
        static void Main (string[] args) {
            int pedido;
            string resultado;

            Console.Write ("Digite o número do seu pedido: ");
            pedido = int.Parse (Console.ReadLine ());

            //Contamos a quantidade de caracteres de um elemento

            //Pegamos o último digito
            // Com o método Substring

            switch (pedido) {

                case 1:
                    resultado = "Hamburguer";
                    break;

                case 2:
                    resultado = "Chesse Salada";
                    break;

                case 3:
                    resultado = "Chesse buguer";
                    break;

                case 4:
                    resultado = "Chesse bacon";
                    break;

                default:
                    resultado = "Opção inválida";
                    break;

            }
            
            Console.WriteLine (resultado);

        }
    }
}