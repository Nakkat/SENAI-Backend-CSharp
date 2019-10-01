using System;
using fic.Desktop.SENAI_Backend_CSharp.aula13_POO_Exercicio.Exercicio5.Models;

namespace fic.Desktop.SENAI_Backend_CSharp.aula13_POO_Exercicio.Exercicio5.Controllers
{
    public class PizzasControllers
    {
        PizzaModel Pizza = new PizzaModel();

        public void CadastrarPizza () {
             System.Console.WriteLine("Digite o tipo da pizza! (Salgada/Doce)");
            Pizza.Tipo = Console.ReadLine();
            
            System.Console.WriteLine("Digite o nome da pizza!");
            Pizza.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite o preço da pizza! (Ex: 26,80 reais)");
            Pizza.Preço = Console.ReadLine();

            System.Console.WriteLine("Digite o tamanho da pizza! (Ex: 5 pedaços)");
            Pizza.Tamanho = Console.ReadLine();
        } 
        public void ExibirPizza (){

        }
            
        
    }
}