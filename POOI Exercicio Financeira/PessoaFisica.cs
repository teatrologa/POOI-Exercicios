using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    public class PessoaFisica : Contrato
    {
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }

        public int Idade
        {
            get
            {

                var idade = Convert.ToInt32(DateTime.Now.Year - Nascimento.Year);

                if (DateTime.Now.DayOfYear < Nascimento.DayOfYear)
                {
                    idade--;
                }

                return idade;
            }

            set { }
        }


        public override void CalcularPrestação()
        {
            var prestacaoFixa = (Valor / Prazo);
            decimal adicional;
            
            switch (Idade)
            {
                case <= 30:
                    adicional = 1.00m;
                    break;

                case <= 40:
                    adicional = 2.00m;
                    break;

                case <= 50:
                    adicional = 3.00m;
                    break;

                case > 50:
                    adicional = 4.00m;
                    break;
            }

             var prestacaoVariadaPF = prestacaoFixa + adicional;
            
            Console.WriteLine("Valor da prestação: R$ " + prestacaoVariadaPF);

        }

        public override void PrintarContrato()
        {

            Header();

            Console.WriteLine("Dados do Constratante");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome: " + Contratante);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Data de Nascimento: " + Nascimento.Date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Idade: " + Idade + " anos");
            Console.WriteLine("");
            Console.WriteLine("");

            base.PrintarContrato();



            //public PessoaFisica(string cpf, DateTime nascimento, string contratante, decimal valor, int prazo)
            //{
            //    CPF = cpf;
            //    Nascimento = nascimento;
            //    Contratante = contratante;
            //    Valor = valor;
            //    Prazo = prazo;
            //}
            //VERIFICAR COMO USAR O CONSTRUTOR CERTINHO

        }


    }
}
