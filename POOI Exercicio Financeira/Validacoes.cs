using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    public class Validacoes
    {

        //VALIDAÇÕES USADAS NO PROJETO DO LETSPET

        public static string InputVazio()
        {
            bool inputValido = false;
            string inputUsuario = "";
            while (!inputValido)
            {
                inputUsuario = Console.ReadLine();
                if (string.IsNullOrEmpty(inputUsuario))
                {
                    Console.WriteLine("Informação Obrigatória. Por favor, digite novamente:");
                }
                else
                {
                    inputValido = true;
                }
            }
            return inputUsuario;
        }


        public static bool ValidadeCPF(string cpf)
        {
            Regex RgxCpf = new(@"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$");
            if (!RgxCpf.Match(cpf).Success)
            {
                Console.WriteLine("CPF digitado inválido!\nDigite novamente no formato: 123.456.789-00.");
                return false;
            }
            return true;
        }

    }

    
}
