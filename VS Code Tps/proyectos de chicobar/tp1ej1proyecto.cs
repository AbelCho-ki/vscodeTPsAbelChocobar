public class tp1proyectoGG
{
/*1. Área de un triángulo: Escribe un programa que solicite la base y la altura de un
triángulo y calcule su área utilizando la fórmula A=(base∗altura)/2 */
  public static void main()
  {
    int A, dabatase, altura;//no se puede usar la palabra "base" por ello uso "dabatase" que es lo mismo xd
    console.writeline("Ingrese la base del tringulo plis.");
    dabatase = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el altura del triangulo perfavore.");
    altura = int.Parse(Console.ReadLine());
    A = (dabatase * altura) / 2;


    Console.ReadKey();

  }
  
 
}