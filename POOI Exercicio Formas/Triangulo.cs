using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Formas
{
    public class Triangulo : Forma
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        public override string CalcularArea()
        {
            return $"A área de um triangulo cuja base é {Base} e altura é {Altura} é de: {(Base * Altura) / 2}";
        }

    }
}
