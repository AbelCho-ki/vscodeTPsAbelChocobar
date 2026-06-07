/*2. Volumen de una caja: Escribe un programa que solicite el largo, el ancho y el alto de
una caja rectangular para calcular su volumen (V=largo∗ancho∗alto)*/
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese el largo: ");
        double largo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el ancho: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el alto: ");
        double alto = Convert.ToDouble(Console.ReadLine());

        
        double volumen = largo * ancho * alto; 

       
        Console.WriteLine("El volumen de la caja es: " + volumen);
    }
}
