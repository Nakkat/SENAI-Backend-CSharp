using System;
using System.IO;
using aula10_POO.Models;


namespace aula10_POO.Controllers
{
    public class ProdutosController
    {

        ProdutosModel produto = new ProdutosModel();
        public void CadastrarProduto (){
         
     try {
               System.Console.WriteLine("Digite o ID do Produto: ");
           produto.IdProduto = int.Parse(System.Console.ReadLine() );

           System.Console.WriteLine("Digite o Nome do Produto: ");
           produto.NomeProduto = System.Console.ReadLine();

           System.Console.WriteLine("Digite a descrição do Produto: ");
           produto.Descricao = System.Console.ReadLine();

           System.Console.WriteLine("Digite o preço do produto: ");
           produto.Preco = double.Parse(System.Console.ReadLine());
     }
     catch (System.Exception ex)
     {
         
         System.Console.WriteLine("Desculpe :( Houve um erro na aplicação");
         SalvarErros(ex);
     }
           
        
           
        }

        public void  ExibirProduto () {

           try {
            System.Console.WriteLine(produto.IdProduto);
            System.Console.WriteLine(produto.NomeProduto);
            System.Console.WriteLine(produto.Descricao);
            System.Console.WriteLine(produto.Preco);
           }
           catch (System.Exception)
           {
               
               throw;
           }
        }
        
        // Primeiro, dentro do streamwriter voce coloca as propriedades 1- erro 2- true p/ não sobrescrever o erro antigo
        private void SalvarErros(Exception ex){
            
            StreamWriter txt = new StreamWriter("error_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();

            txt.Close();
        }
    }
}