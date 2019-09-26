namespace aula9.Models {

// Ponto e vírgula dentro das chaves get e set e fora not
// As chaves sempre vão ter, e existirá a adição do () quando for void sendo que  o nome da classe não pode ter espaços
    public class AlunoModel {
        public string nome {get; set;}
        public string curso {get; set;}
        public string RA {get; set;}
    
    public void Estudar (){
        System.Console.WriteLine("Estou estudando");
    }
    public void PedirIntervalo()
    {
        System.Console.WriteLine("Pode fazer intervalo aeee");
        System.Console.WriteLine("QUEO CAFÉÉÉ!!");
    }
    public void PedirAjuda() {
        System.Console.WriteLine("Ô Paulo, chega ae!");
    }
    }
}