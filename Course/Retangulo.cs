using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (Largura + Altura) * 2;
        }

        public double Diagonal() {
            double calc = Largura * Largura + Altura * Altura;
            return Math.Sqrt(calc);
        }

        public override string ToString()
        {
            return "Área = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "; Perímetro = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "; Diagonal = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

                    
        }

    }
}
