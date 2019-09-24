using System;

namespace aula5exercicio {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[3];
            double[] valor = new double[3];
            string sair = "";
            double acum = 0;

            Console.WriteLine ("Bem vindo!");

            while (sair != "0") {

                Console.WriteLine (
                    @"
                    Menu:
                    1 - Cadastrar produto
                    2 - Listar produtos
                    3 - Soma dos produtos
                    0 - Sair");

                sair = Console.ReadLine ();

                switch (sair) {
                    case "1":
                        for (int i = 0; i <= 2; i++) {
                            Console.Write ("Digite o nome do produto: ");
                            nome[i] = Console.ReadLine ();
                            Console.Write ("Digite o valor: ");
                            valor[i] = double.Parse (Console.ReadLine ());
                            Console.WriteLine ("Produto Cadastrado!");

                        }

                        break;

                    case "2":
                        for (int i = 0; i <= 2; i++) { 

                            Console.WriteLine (nome[i] +"  "+valor[i]);

                        }
                        break;

                    case "3":
                        for (int i = 0; i <= 2; i++) {
                            acum = acum + valor[i];
                            
                        }
                        Console.WriteLine(acum);
                        break;

                    default:
                        Console.WriteLine ("Saiu da aplicação");
                        break;
                }
               
            }

            /*  1- Cadastrar um produto que terá nome e um preço
            2- Listar todos os produtos
            3- Calcular a soma de todos os preços dos produtos */

        }
    }
}