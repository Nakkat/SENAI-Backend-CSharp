using System;

namespace aula8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            try{

                // Escrevemos um bloco de código
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            }catch(Exception ex){
                // Mostramos a excessaõ da regra
                // Erro gerad na aplicação
                Console.WriteLine("Ops :( Algo de errado não está certo!" + ex);
            }
        }
    }
}
