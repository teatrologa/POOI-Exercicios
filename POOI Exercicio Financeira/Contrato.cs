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
            
            Console.WriteLine("Dados do Contrato");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Valor: R$ " + Valor);
            Console.WriteLine("Prazo: " + Prazo + " meses");
            CalcularPrestação();
            Console.WriteLine("ID de Segurança: " + IDContrato);
            Console.WriteLine("");

        }

        public virtual void Header ()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("        CONTRATO        ");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
