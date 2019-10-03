
using System;
using System.Collections.Generic;
using aula14_Lista_Construtor.Models;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa classe com o método construtor passando os parâmetros
            ProdutoModel produto = new ProdutoModel( 1, "Maçã", "Verde", 3.5);

            // Chamamos um atributo do objeto instanciado
            System.Console.WriteLine(produto.NomeProduto);

            // Instanciamos nossa classe sem passar parâmentros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();

            // Alimentamos nosso objeto que estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;

            // Chamamos a nossa lista que vai ser do objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adicionamos objetos instanciados e atribuídos em nossa lista
            prod.Add( new ProdutoModel(1, "Cenoura", "Laranja", 2.30));
            prod.Add( new ProdutoModel(2, "Mamão", "Laranja", 2.30));
            prod.Add( new ProdutoModel(3, "Beterraba", "Vermelha", 2.30));
            prod.Add( new ProdutoModel(4, "Pastel", "Queijo", 2.30));
            prod.Add( new ProdutoModel(5, "Caldo de Cana", "Suco", 2.30));
            prod.Add( new ProdutoModel(6, "Chuchu", "Verde", 2.30));

            // Lemos os dados da nossa lista
            foreach(ProdutoModel p in prod){
                System.Console.WriteLine();
                System.Console.WriteLine(p.IdProduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();
            }

            // Chamamos através do indice um atributo específico
            System.Console.WriteLine(prod[4].NomeProduto);
        }
    }
}