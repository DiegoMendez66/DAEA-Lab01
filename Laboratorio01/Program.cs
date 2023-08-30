// See https://aka.ms/new-console-template for more information

using Laboratorio01;

//Persona persona = new Persona();
//persona.Apellidos = "Mendez";
//persona.Nombres = "Diego";
//persona.Edad = 21;

//Console.WriteLine("Los nombres completos son:");
//Console.WriteLine(persona.RetornarNombresCompletos());

//if (persona.EsMayorEdad())
//    Console.WriteLine("Es mayor de Edad");
//else
//    Console.WriteLine("Es menor de Edad");

//Empleado empleado = new Empleado
//{s
//    Nombres = "Diego",
//    Apellidos = "Mendez",
//    Edad = 21,
//    Codigo = 1,
//    Sueldo = 5000,
//};

//Console.WriteLine("-----------------");
//Console.WriteLine("Codigo: " + empleado.Codigo);
//Console.WriteLine("Impuesto calculado: " + empleado.CalcularImpuesto(18));

CajeroAutomatico cajeroAutomatico = new CajeroAutomatico
{
    Cuenta = 4512,
    Titular = "Diego Mendez",
    Saldo = 10000,
    Pin = 1234,
};


Console.Write("Ingresa tu PIN: ");
int PIN = Convert.ToInt32(Console.ReadLine());

if (PIN == cajeroAutomatico.Pin)
{
    int opcion;
    do
    {
        MostrarMenu();
        opcion = ObtenerOpcion();

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Saldo actual: " + cajeroAutomatico.ConsultarSaldo());
                break;
            case 2:
                Console.Write("Ingrese fondos: ");
                double fondo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Fondo depositado. Saldo actual: " + cajeroAutomatico.DepositarFondos(fondo));
                break;
            case 3:
                Console.Write("Ingrese el monto a retirar: ");
                double retiro = Convert.ToDouble(Console.ReadLine());
                if (cajeroAutomatico.Saldo >= retiro)
                {
                    Console.WriteLine("Retirado: " + retiro);
                    Console.WriteLine("Saldo actual: " + cajeroAutomatico.RetirarEfectivo(retiro));
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes");
                }
                break;
            case 4:
                Console.Write("Ingresa el nuevo PIN: ");
                int nuevoPin = Convert.ToInt32(Console.ReadLine());
                cajeroAutomatico.CambiarPin(nuevoPin);
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                break;
        }

    } while (opcion != 5);

} else{
    Console.WriteLine("PIN inválido");
}

static void MostrarMenu()
{
    Console.WriteLine("----- Menú de Opciones -----");
    Console.WriteLine("1. Consultar saldo ");
    Console.WriteLine("2. Despositar fondos ");
    Console.WriteLine("3. Retirar efectivo ");
    Console.WriteLine("4. Cambiar PIN ");
    Console.WriteLine("5. Salir");
    Console.Write("Selecciona una opción: ");
}

static int ObtenerOpcion()
{
    int opcion;
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Write("Entrada inválida. Por favor, ingresa un número válido: ");
    }
    return opcion;
}


