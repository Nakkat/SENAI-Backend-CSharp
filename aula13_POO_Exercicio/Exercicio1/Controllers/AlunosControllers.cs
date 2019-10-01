using System;
using System.IO;
using Exercicio1.Models;

namespace Exercicio1.Controllers {
    public class AlunosControllers {
        AlunoModel aluno = new AlunoModel ();

        string Bolsa;

        public void CadastrarAluno () {
            try {
                Console.WriteLine ("Digite seu nome: ");
                aluno.NomeAluno = Console.ReadLine();
                System.Console.WriteLine ("Digite o nome do seu curso: ");
                aluno.CursoAluno = Console.ReadLine ();
                System.Console.WriteLine ("Digite sua idade: ");
                aluno.IdadeAluno = int.Parse(Console.ReadLine());
                System.Console.WriteLine ("Digite se é bolsista (s/n): ");
                Bolsa = Console.ReadLine ();

                if (Bolsa == "s" || Bolsa == "S") {
                    aluno.Bolsista = true;
                } else if (Bolsa == "n" || Bolsa == "N") {
                    aluno.Bolsista = false;
                } else {
                    System.Console.WriteLine ("Opção inválida! :(");
                }

            } catch (System.Exception ex) {

                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação");
                SalvarErros (ex);
            }   
        }
        public void  ExibirAluno () {

           try {
            System.Console.WriteLine(aluno.NomeAluno);
            System.Console.WriteLine(aluno.CursoAluno);
            System.Console.WriteLine(aluno.IdadeAluno);
            System.Console.WriteLine(aluno.Bolsista);
           }
           catch (System.Exception)
           {
               
               throw;
           }
        }

        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();
        }
    }
}