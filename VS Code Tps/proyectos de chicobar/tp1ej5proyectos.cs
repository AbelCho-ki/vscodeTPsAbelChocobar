/*5. Conversión de tiempo: Escribe un programa que solicite una cantidad de horas y
calcule su equivalente total en minutos y en segundos*/
using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese la cantidad de horas: ");
        double horas = Convert.ToDouble(Console.ReadLine());

        double minutos = horas * 60;

        double segundos = horas * 3600;

        Console.WriteLine("Equivalente en minutos: " + minutos);
        Console.WriteLine("Equivalente en segundos: " + segundos);
    }
}