using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    public class Contrato
    {
        public Guid IDContrato { get { return Guid.NewGuid(); } private set { } }

        public string? Contratante { get; set; }

        public decimal Valor { get; set; }

        public int Prazo { get; set; }

        public virtual void CalcularPrestação()
        {        
        }

        public virtual void PrintarContrato()
        {
            Console.Clear();
            Console.WriteLine("CONTRATO");
            Console.WriteLine("--------");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
