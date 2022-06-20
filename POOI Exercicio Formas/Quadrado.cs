using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Formas
{
    public class Quadrado : Forma
    {
        public decimal Lado { get; set; }


        public override string CalcularArea()
        {
            return $"A área do quadrado de lado {Lado} é de: {Lado * Lado}";
        }
    }
}
