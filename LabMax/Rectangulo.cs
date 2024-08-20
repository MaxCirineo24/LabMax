using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMax
{
    internal class Rectangulo
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public int X3 { get; set; }
        public int Y3 { get; set; }

        public int X4 { get; set; }
        public int Y4 { get; set; }

        public Rectangulo(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;

        }

        
        public int CalcularBase()
        {
            return Math.Abs(X2 - X1);
        }

       
        public int CalcularAltura()
        {
            return Math.Abs(Y2 - Y1);
        }

       
        public int CalcularArea()
        {
            return CalcularBase() * CalcularAltura();
        }

        
        public int CalcularPerimetro()
        {
            return 2 * (CalcularBase() + CalcularAltura());
        }
    }
}
