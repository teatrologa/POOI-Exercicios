using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    internal class PessoaJuridica : Contrato
    {
        public string CNPJ { get; set; }

        public string InscricaoEstadual { get; set; }
        public PessoaJuridica(Guid idContrato, string? contratante, decimal valor, int prazo, string cnpj, string inscricaoEstadual) : base(idContrato, contratante, valor, prazo)
        {
            CNPJ = cnpj;
            InscricaoEstadual = inscricaoEstadual;
        }

        public override void PrintarContrato()
        {
            base.PrintarContrato();

            Console.WriteLine("\tDados do Constratante");
            Console.WriteLine("Nome: " + Contratante);
            Console.WriteLine("CPF: " + CNPJ);
            Console.WriteLine("Data de Nascimento: " + InscricaoEstadual);
            Console.WriteLine("");

            Console.WriteLine("\tDados do Contrato");
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine("Prazo: " + Prazo);
            Console.WriteLine("ID de Segurança: " + IDContrato);
        }
    }
}
