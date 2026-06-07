/*calcule el monto del IVA (21%) y el precio total final.*/
using System;

class Program
{
    static void Main()
    {
        // 1. Solicitar el precio neto
        Console.Write("Ingrese el precio neto del producto: ");
        double precioNeto = Convert.ToDouble(Console.ReadLine());

        // 2. Calcular el IVA (21%) y el precio total
        // [TU TURNO]: Multiplicá precioNeto por 0.21
        double montoIva = 

        // [TU TURNO]: Sumá el precioNeto y el montoIva
        double precioTotal = 

        // 3. Mostrar los resultados
        Console.WriteLine("Monto del IVA (21%): $" + montoIva);
        Console.WriteLine("Precio total final: $" + precioTotal);
    }
}
