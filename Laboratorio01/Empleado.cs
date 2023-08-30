using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class Empleado: Persona
    {
        public int Codigo { get; set; }
        public double Sueldo { get; set;}

        public double CalcularImpuesto(double imp)
        {
            return (Sueldo * imp) / 100;
        }
    }
}
