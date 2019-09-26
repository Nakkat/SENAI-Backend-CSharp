using System;

namespace aula6_3 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite o cnpj: ");
            string cnpj = Console.ReadLine ();

            Console.WriteLine (ValidaCNPJ (cnpj));
            //http://www.macoratti.net/alg_cnpj.htm

        }

        static bool ValidaCNPJ (string cnpjUsuario) {

            bool resultado = false;
            int[] v1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cnpjCalculo = "";
            int resto = 0;
            int calculo = 0;

            string digito_v1 = "";
            string digito_v2 = "";

            // Replace - Se o usuário digitar . traço ou espaço é desconsiderado 

            cnpjUsuario = cnpjUsuario.Replace(" ", "");
            cnpjUsuario = cnpjUsuario.Replace(",", "");
            cnpjUsuario = cnpjUsuario.Replace("-", "");
            cnpjUsuario = cnpjUsuario.Replace(".", "");
            cnpjUsuario = cnpjUsuario.Replace("/", "");

            cnpjCalculo = cnpjUsuario.Substring (0, 12);

            for (int i = 0; i <= 11; i++) {
                calculo += int.Parse (cnpjCalculo[i].ToString ()) * v1[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (resto < 2) {
                digito_v1 = "0";
            } else {
                digito_v1 = calculo.ToString ();
            }

            if (digito_v1 == cnpjUsuario[12].ToString ()) {
                resultado = true;
            }

            int[] v2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            resto = 0;

            cnpjCalculo = cnpjCalculo + calculo;
            calculo = 0;

            for (int i = 0; i <= 12; i++) {
                calculo += int.Parse (cnpjCalculo[i].ToString ()) * v2[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (resto < 2) {
                digito_v2 = "0";
            } else {
                digito_v2 = calculo.ToString ();
            }

            if (digito_v2 == cnpjUsuario[13].ToString ()) {
                resultado = true;
            }

            return resultado;

        }

    }
}