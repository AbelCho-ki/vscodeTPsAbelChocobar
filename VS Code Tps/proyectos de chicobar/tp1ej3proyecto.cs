/*3. Conversión de moneda inversa: Escribe un programa que solicite una cantidad en
pesos argentinos y el tipo de cambio actual para convertirlo a dólares*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad en pesos argentinos: ");
        double pesos = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tipo de cambio actual: ");
        double tipoCambio = Convert.ToDouble(Console.ReadLine());

        double dolares = pesos / tipoCambio;

        Console.WriteLine("La cantidad en dólares es: " + dolares);
    }
}