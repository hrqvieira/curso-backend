using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class ConversorDeMoeda {



        public static double CalcCotacao(double valorCotacao, double quantDolar) {
            double totalConvertido = valorCotacao * quantDolar;
            return totalConvertido + totalConvertido * 0.06;  
        }

    }
}
