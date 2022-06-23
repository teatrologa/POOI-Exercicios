using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    public class Contrato
    {
        public Guid IDContrato { get { return IDContrato = new Guid(); } private set { } }

        public string? Contratante { get; set; }

        public decimal Valor { get; set; }

        public int Prazo { get; set; }


        public virtual void PrintarContrato()
        {
            Console.Clear();
            Console.WriteLine("\tCONTRATO");
            Console.WriteLine("\t--------");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
