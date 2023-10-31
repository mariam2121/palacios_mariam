using System;
using System.Collections.Generic;

class Ejerc1
{
    static void Main(string [] args)
    {
        Console.WriteLine("Hola, como anda?");
        Console.Write("ingresa la cantidad de cadenas que quiera: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadCadenas))
        {
            Stack<string> cadena_pila = new Stack<string>();

            for (int i = 0; i < cantidadCadenas; i++)
            {
                Console.Write($"Ingresa la cadena {i + 1}: ");
                string cadena = Console.ReadLine();
                cadena_pila.Push(cadena);
            }

            int sumaConsonantes = CalcularSumaConsonantes(cadena_pila);
            Console.WriteLine($"La suma de consonantes en la pila es: {sumaConsonantes}");
        }
        else
        {
            Console.WriteLine("la entrada no es correcta, ingrese otra");
        }
    }

    static int CalcularSumaConsonantes(Stack<string> cadena_pila)
    {
        int sumaConsonantes = 0;
        string consonantes = "bcdfghijkmnñlpqrstvwxyz";

        while (cadena_pila.Count > 0)
        {
            string cadena = cadena_pila.Pop();

            foreach (char A in cadena.ToLower())
            {
                if (consonantes.Contains(A))
                {
                    sumaConsonantes++;
                }
            }
        }

        return sumaConsonantes;
    }
}