using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Formas
{
    public class Retangulo : Forma
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        public override string CalcularArea()
        {
            return $"A área do retangulo de base {Base} e altura {Altura} é de: {Base * Altura}";
        }
    }
}
