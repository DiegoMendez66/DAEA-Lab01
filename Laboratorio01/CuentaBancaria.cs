using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class CuentaBancaria
    {
        public int Cuenta { get; set; }
        public string ? Titular { get; set; }
        public double Saldo { get; set; }
        public int Pin { get; set; }
    }
}
