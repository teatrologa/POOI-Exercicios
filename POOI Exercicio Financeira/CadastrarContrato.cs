using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    public class CadastrarContrato
    {

        public void CadastrarContratoPF()
        {
            Console.Clear();
            PessoaFisica novoContratoPF = new PessoaFisica();

            Console.WriteLine("Insira o nome do contratante:");
            novoContratoPF.Contratante = Console.ReadLine();

            Console.WriteLine("Insira o CPF do contratante: [ex: 123.456.789-00]");
            novoContratoPF.CPF = Console.ReadLine();

            Console.WriteLine("Insira a data de nascimento do contratante: [ex: dd/mm/aaaa]");
            novoContratoPF.Nascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do contrato: [ex: XXXX.xx]");
            novoContratoPF.Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o prazo do contrato em meses: [ex: 12]");
            novoContratoPF.Prazo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");

            novoContratoPF.PrintarContrato();

        }

        public void CadastrarContratoPJ()
        {
            Console.Clear();
            PessoaJuridica novoContratoPJ = new PessoaJuridica();

            Console.WriteLine("Insira o nome da empresa:");
            novoContratoPJ.Contratante = Console.ReadLine();

            Console.WriteLine("Insira o CNPJ da empresa: [ex: 12.345.678/9999-00]");
            novoContratoPJ.CNPJ = Console.ReadLine();

            Console.WriteLine("Insira a Inscrição Estadual da empresa:");
            novoContratoPJ.InscricaoEstadual = Console.ReadLine();

            Console.WriteLine("Insira o valor do contrato: [ex: XXXX.xx]");
            novoContratoPJ.Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o prazo do contrato em meses: [ex: 12]");
            novoContratoPJ.Prazo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");

            novoContratoPJ.PrintarContrato();
        }
    }
}
