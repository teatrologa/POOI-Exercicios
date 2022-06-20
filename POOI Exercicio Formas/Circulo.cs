using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Formas
{
    public class Circulo : Forma 
    {
        public double Raio { get; set; }
        public override string CalcularArea()
        {
            return $"A área do círculo cujo o raio é {Raio} é de: {(Math.Pow(Raio, 2) * Math.PI)}";
        }
    }
}

//Expoente:
//Math.Pow(x, y);
//x = base
//y = expoente
//Funciona com double, int
//NÃO funciona com decimal
