using System;
using System.IO;
using Exercicio3.Models;

namespace Exercicio3.Controllers
{
    public class ProdutoControllers
    {
        
        ProdutoModel Produto = new ProdutoModel();

        string ReservarProduto;
        public void CadastrarProduto () {
            try {
                Console.WriteLine ("Digite o nome do produto: ");
                Produto.NomeProduto = Console.ReadLine();
                System.Console.WriteLine ("Digite a marca do produto: ");
                Produto.MarcaProduto = (Console.ReadLine());
                System.Console.WriteLine ("Digite a cor do produto: ");
                Produto.CorProduto = Console.ReadLine ();
                System.Console.WriteLine ("Digite a quantidade: ");
                Produto.QtdProduto = int.Parse(Console.ReadLine());
                System.Console.WriteLine ("O produto está reservado? (s/n): ");
                ReservarProduto = Console.ReadLine ();

                if (ReservarProduto == "s" || ReservarProduto == "S") {
                    Produto.ProdutoReservado = true;
                } else if (ReservarProduto == "n" || ReservarProduto == "N") {
                    Produto.ProdutoReservado = false;
                } else {
                    System.Console.WriteLine ("Opção inválida! :(");
                }

            } catch (System.Exception ex) {

                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação");
                SalvarErros (ex);
            }   
        }
        public void  ExibirProduto () {

           try {
            System.Console.WriteLine(Produto.NomeProduto);
            System.Console.WriteLine(Produto.MarcaProduto);
            System.Console.WriteLine(Produto.CorProduto);
            System.Console.WriteLine(Produto.QtdProduto);
            System.Console.WriteLine(Produto.ProdutoReservado);
           }
           catch (System.Exception ex)
           {
               
             System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação");
                SalvarErros (ex);
           }
        }

        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();
        }
    }
}
    
