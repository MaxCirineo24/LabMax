using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las coordenadas del rectángulo:");
            Console.Write("X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

           
            Rectangulo rectangulo = new Rectangulo(x1, y1, x2, y2, x3, y3, x4, y4);

            
            Console.WriteLine($"Base del rectángulo: {rectangulo.CalcularBase()}");
            Console.WriteLine($"Altura del rectángulo: {rectangulo.CalcularAltura()}");
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro()}");
        }
    }
}
