using System;
using Exercicio1.Controllers;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosControllers aluno = new AlunosControllers();

            aluno.CadastrarAluno();
            aluno.ExibirAluno();
        }
    }
}
