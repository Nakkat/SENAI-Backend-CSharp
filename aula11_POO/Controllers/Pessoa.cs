using System;
using System.IO;
using aula11_POO.Models;

namespace aula11_POO.Controllers
{
    public class Pessoa
    {
   
    public class PessoaController
    {

        PessoaModel pessoa = new PessoaModel();
            double imc;

            public void Cadastrarpessoa (){
         
     try {
           System.Console.WriteLine("Digite seu nome: ");
           pessoa.NomePessoa = System.Console.ReadLine();

           System.Console.WriteLine("Digite a sua idade: ");
           pessoa.Idade = int.Parse(System.Console.ReadLine() );

           System.Console.WriteLine("Digite seu peso(quilogramas): ");
           pessoa.Peso = double.Parse(System.Console.ReadLine().Replace("kg",""));

           System.Console.WriteLine("Digite a sua altura: ");
           pessoa.Altura = double.Parse(System.Console.ReadLine().Replace("M", ""));
     }
     catch (System.Exception ex)
     {
         
         System.Console.WriteLine("Desculpe :( Houve um erro na aplicação");
         SalvarErros(ex);
     }
           
        }

        public void  ExibirPessoa () {

           try {
            System.Console.WriteLine("Seu nome é: " + pessoa.NomePessoa);
            System.Console.WriteLine("Sua idade: " + pessoa.Idade);
            System.Console.WriteLine("Seu peso: " + pessoa.Peso);
            System.Console.WriteLine("Sua altura: " + pessoa.Altura);
           }
           catch (System.Exception ex)
     {
         
         System.Console.WriteLine("Desculpe :( Houve um erro na aplicação");
         SalvarErros(ex);
     }
           
        }

        public double CalculoIMC() {
            imc = pessoa.Peso / Math.Pow(pessoa.Altura, 2) ;
            if (imc < 18.5) {
                System.Console.WriteLine("Abaixo do peso!");
            } else if ( imc >= 18.5 && imc <= 25) {
              System.Console.WriteLine("Peso Normal");
            } else if ( imc >= 26 && imc <= 30) {
              System.Console.WriteLine("Sobrepeso!");

            } else if ( imc >= 31 && imc <= 35) {
              System.Console.WriteLine("Obesidade Grau 1!");
            
            } else if ( imc >= 36 && imc <= 39) {
              System.Console.WriteLine("Obesidade Grau 2!");

            } else if ( imc >= 40) {
              System.Console.WriteLine("Obesidade Grau 3!");
            }
        return imc;
        }

        
        // Primeiro, dentro do streamwriter voce coloca as propriedades 1- erro 2- true p/ não sobrescrever o erro antigo
        // Encapsulamento - Private or public 
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
}

    
