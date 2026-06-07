/*Descuento en tienda: Escribe un programa que solicite el precio de un artículo y
calcule el precio final tras aplicar un descuento del 15%*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio original del artículo: ");
        double precioOriginal = Convert.ToDouble(Console.ReadLine());
        double descuento = precioOriginal * 0.15;
        double precioFinal = precioOriginal - descuento;
        
        Console.WriteLine("El precio final con el 15% de descuento es: " + precioFinal);
    }
}