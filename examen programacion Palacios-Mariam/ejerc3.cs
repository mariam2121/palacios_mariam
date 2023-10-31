using System;
using System.Collections.Generic;

class Ejerc3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, como anda profe? jiji")
        Console.Write("ingrasa la cantidad de numeros que quiera: ");
        if (int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Queue<int> micola = new Queue<int>();

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el nuemro #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    micola.Enqueue(numero);
                }
                else
                {
                    Console.WriteLine("entrada incorrecta, intente nuevamente ");
                    i--;
                }
            }

            int minimo = int.MaxValor;
            int maximo = int.MinValor;

            foreach (int numero in  micola)
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }
            }

            Console.WriteLine($"El valor mínimo en la cola es: {minimo}");
            Console.WriteLine($"El valor máximo en la cola es: {maximo}");
        }
        else
        {
            Console.WriteLine("entrada incorrecta, ingresa otro numero");
        }
    }
}
