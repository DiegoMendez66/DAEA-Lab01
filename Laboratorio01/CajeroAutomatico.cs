using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class CajeroAutomatico: CuentaBancaria
    {
        public double ConsultarSaldo()
        {
            return Saldo;
        }

        public double DepositarFondos(double fondos)
        {
            return Saldo + fondos;
        }
         public double RetirarEfectivo(double retiro)
        {
            return Saldo - retiro;
        }
        public void CambiarPin(int nuevoPin)
        {
            Pin = nuevoPin;
            Console.WriteLine("PIN cambiado exitosamente.");
        }
    }
}
