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


        public override void CalcularPrestação()
        {
            var prestacaoFixa = (Valor / Prazo);
            var prestacaoVariadaPJ = prestacaoFixa + 3.00m;
            Console.WriteLine("Valor da prestação: R$ " + prestacaoVariadaPJ);
        }


        public override void PrintarContrato()
        {
            Console.Clear();

            Console.WriteLine("Dados do Constratante");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome da empresa: " + Contratante);
            Console.WriteLine("CNPJ: " + CNPJ);
            Console.WriteLine("Inscrição estadual: " + InscricaoEstadual);
            Console.WriteLine("");
            Console.WriteLine("");

            base.PrintarContrato();
        }
    }
}
