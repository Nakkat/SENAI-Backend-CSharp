using System;
using static aula11_POO.Controllers.Pessoa;

namespace aula11_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaController pessoa = new PessoaController();

            pessoa.Cadastrarpessoa();
            pessoa.ExibirPessoa();
            System.Console.WriteLine(" ");
            pessoa.CalculoIMC();

            
        }
    }
}
