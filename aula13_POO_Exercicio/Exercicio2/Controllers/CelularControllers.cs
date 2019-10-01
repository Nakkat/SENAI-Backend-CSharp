using Exercicio2.Models;

namespace Exercicio2.Controllers {
    public class CelularControllers {
        CelularModel  Celular = new CelularModel ();
        
        public void Ligar () {
            Celular.Ligado = true;
            System.Console.WriteLine ("Ligando celular...");
        }

        public void Desligar () {

            Celular.Ligado = false;
            System.Console.WriteLine ("Deligando celular...");
        }

        public void Ligacao () {
            if (Celular.Ligado == true) {
                System.Console.WriteLine ("Efetuando ligação...");
            } else {
                System.Console.WriteLine ("O celular não está ligado! Impossível fazer ligações!");
            }
        }
        public void Mensagem () {
            if (Celular.Ligado == true) {
                System.Console.WriteLine ("Celular enviando mensagem...");
            } else {
                System.Console.WriteLine ("O celular não está ligado! Impossível enviar mensagens!");
            }
        }

        

    }

}