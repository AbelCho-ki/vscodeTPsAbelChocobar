/*8. Promedio extendido: Escribe un programa que solicite al usuario ingresar cinco notas
de exámenes y calcule el promedio final del estudiante*/
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
