        int A, dabatase, altura; 
        //no se puede usar la palabra "base" por ello uso "dabatase" que es lo mismo.
        
        int numero;
        numero = int.TryParse(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("Es un número negativo.");
        }
        else
        {
            Console.WriteLine("Es un número positivo.");
        }
        Console.ReadKey();

