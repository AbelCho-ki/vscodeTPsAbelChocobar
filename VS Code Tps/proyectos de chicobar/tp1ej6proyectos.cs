/*6. Cálculo de velocidad: Escribe un programa que solicite la distancia recorrida (en km) y
el tiempo empleado (en horas) para calcular la velocidad promedio (v=d/t)*/
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese la distancia recorrida (en km): ");
        double  distancia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo empleado (en horas): ");
          double tiempo = Convert.ToDouble(Console.ReadLine());

         double velocidad = distancia / tiempo;
        Console.WriteLine("La velocidad promedio es: " + velocidad + " km/h");
    }
}
