using System;
using aula12_POO_Heranca_Composicao_Encapsulamento.Controllers;


namespace aula12_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carro = new CarrosController();
            CarrosEletricosController carroEletrico = new CarrosEletricosController();
               
            Console.Clear(); //Limpa a tela do terminal   
            
           carroEletrico.CarregarBateria(15);
           System.Console.WriteLine("Carga do carro: " + carroEletrico.StatusBateria());

           
            
        }
    }
}
