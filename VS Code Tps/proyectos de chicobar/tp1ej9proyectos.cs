/*9. Porcentaje de asistencia: Escribe un programa que solicite la cantidad total de días de
clase y la cantidad de asistencias de un alumno para calcular su porcentaje de
presencialidad*/
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese la cantidad total de días de clase: ");
        int totalDias = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la cantidad de asistencias del alumno: ");
        int asistencias = Convert.ToInt32(Console.ReadLine());
        double porcentaje = (double)asistencias * 100.0 / totalDias;

        Console.WriteLine("El porcentaje de presencialidad es: " + porcentaje + "%");
    }
}
