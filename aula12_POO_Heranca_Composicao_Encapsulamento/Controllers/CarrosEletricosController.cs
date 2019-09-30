using aula12_POO_Heranca_Composicao_Encapsulamento.Models;

namespace aula12_POO_Heranca_Composicao_Encapsulamento.Controllers {
    public class CarrosEletricosController : CarrosController {
        CarrosEletricosModel carroEletrico = new CarrosEletricosModel ();

        MotorModel motor = new MotorModel ();

        public void CarregarBateria (float carga) {
            if (carroEletrico.Bateria < 100) {

                carroEletrico.Bateria += carga;
            } else {
                System.Console.WriteLine("A bateria do carro já está completa! Pode Viajar!");
            }
        }
        public float StatusBateria() 
        { 
            return carroEletrico.Bateria;
        }
    }
}