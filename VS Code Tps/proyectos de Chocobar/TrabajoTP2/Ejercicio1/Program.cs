
public class tp1proyectoGG
{

  public static void main()
  {
    int A, dabatase, altura;//no se puede usar la palabra "base" por ello uso "dabatase" que es lo mismo

    console.writeline("Ingrese la base del tringulo plis.");
    dabatase = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el altura del triangulo perfavore.");
    altura = int.Parse(Console.ReadLine());
    A = (dabatase * altura) / 2;
    console.writeline("El area de ese triangulo es " + A);

    Console.ReadKey();

  }


}

