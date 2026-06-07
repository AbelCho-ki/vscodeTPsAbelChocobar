/*7. Perímetro de un círculo: Escribe un programa que solicite el radio de un círculo y
calcule su perímetro (longitud) usando la fórmula P=2∗π∗r*/
using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

   
        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine("El perímetro del círculo es: " + perimetro);
    }
}
