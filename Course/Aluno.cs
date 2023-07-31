using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Aluno
    {
        public double NotaUm;
        public double NotaDois;
        public double NotaTres;





        public double CalcNota() {
            return NotaUm + NotaDois + NotaTres;
        }

        public bool VerificarAprovado() {
            if (CalcNota() >= 60)
            {
                return true;
            }
            else {
                return false;
            }

        }

        public double NotaRestante() {
            if (VerificarAprovado())
            {
                return 0.0;
            }
            else {
                return 60.0 - CalcNota();
            }
        }



        

    }
}
