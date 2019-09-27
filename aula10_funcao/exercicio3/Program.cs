using System;

namespace exercicio3 {
    class Program {
        static void Main (string[] args) {
            MostraInfo ();

            string nome, sobrenome;
            int idade;
            float peso, altura;

            System.Console.WriteLine ("Qual é o seu nome: ");
            nome = Console.ReadLine ();

            System.Console.WriteLine ("Qual é o seu sobrenome: ");
            sobrenome = Console.ReadLine ();

            System.Console.WriteLine ("Qual a sua idade: ");
            idade = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Qual é o seu peso: ");
            peso = float.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Qual é a sua altura: ");
            altura = float.Parse (Console.ReadLine ());

            

            MostraInfo (idade, peso, altura);

            Console.WriteLine ("Seu nome completo é " + MostraInfo (nome, sobrenome));
            Console.WriteLine(" ");

            Console.WriteLine ("Sua idade é: " + idade);
            Console.WriteLine(" ");

            Console.WriteLine ("Seu peso é: " + peso);
            Console.WriteLine(" ");
            
            Console.WriteLine ("Sua altura é: " + altura);
               
        }
        static void MostraInfo () {

            Console.WriteLine ("SERVICO NACIONAL DE APRENDIZAGEM INDUSTRIAL");
            Console.WriteLine(" ");
        }
        static string MostraInfo (string nome, string sobrenome) {
            string NomeCompleto;
            NomeCompleto = nome + " " + sobrenome;
            return (NomeCompleto);
        }

        static string MostraInfo (int idade, float peso, float altura) {
            string dados2;
            dados2 = idade.ToString(); peso.ToString(); altura.ToString();
            return (dados2);
        }

    }
}