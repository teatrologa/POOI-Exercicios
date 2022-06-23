using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    public class PessoaFisica : Contrato
    {
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }


        public override void PrintarContrato()
        {
            base.PrintarContrato();

            Console.WriteLine("Dados do Constratante");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome: " + Contratante);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Data de Nascimento: " + Nascimento.Date);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Dados do Contrato");
            Console.WriteLine("-----------------");
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine("Prazo: " + Prazo);
            Console.WriteLine("ID de Segurança: " + IDContrato);
            Console.WriteLine("");




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
