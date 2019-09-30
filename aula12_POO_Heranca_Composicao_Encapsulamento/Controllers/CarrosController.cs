using System;
using aula12_POO_Heranca_Composicao_Encapsulamento.Models;

namespace aula12_POO_Heranca_Composicao_Encapsulamento.Controllers {
    public class CarrosController {
        CarroModel carro = new CarroModel();
        MotorModel Motor = new MotorModel();

        public object Eletrico { get; internal set; }

        public void Ligar () {
            carro.Ligado = true;
            System.Console.WriteLine ("Ligando carro!");
        }

        public void Desligar () {
            
                carro.Ligado = false;
                System.Console.WriteLine ("Deligando carro...");
            }
        

        public void Acelerar () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro acelerando!");
            } else {
                System.Console.WriteLine ("O carro não está ligado! Impossível acelerar!");
            }
        }
        public void Frear () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro freando...");
            } else {
                System.Console.WriteLine ("O carro não está ligado! Impossível frear");
            }
        }
        public void CadastrarMotor() 
        {
            System.Console.WriteLine("Insira quantos cavalos tem o motor: ");
            Motor.Cavalos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira quantos cilindros tem o motor: ");
            Motor.Cilindros = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o modelo do pistão do carro: ");
            Motor.Pistao = (Console.ReadLine());
        }

    }
}