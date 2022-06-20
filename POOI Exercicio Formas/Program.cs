namespace POOI_Exercicio_Formas
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Calculo de áreas:");
            Console.WriteLine(" ");

            var quadrado = new Quadrado();
            quadrado.Lado = 5;
            Console.WriteLine(quadrado.CalcularArea());
            Console.WriteLine("--------------------------------------");

            Console.WriteLine(" ");
            var retangulo = new Retangulo();
            retangulo.Base = 10;
            retangulo.Altura = 4;
            Console.WriteLine(retangulo.CalcularArea());
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine(" ");
            var triangulo = new Triangulo();
            triangulo.Base = 3;
            triangulo.Altura = 4;
            Console.WriteLine(triangulo.CalcularArea());
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine(" ");
            var circulo = new Circulo();
            circulo.Raio = 3;
            Console.WriteLine(circulo.CalcularArea());
            Console.WriteLine("----------------------------------------------------------");


        }
    }
}