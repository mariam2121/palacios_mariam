using System;
using System.Collections.Generic;

class Ejerc2
{
    static void Main(string[] args)
    {

        int[,] matriz_1 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        int[,] matriz_2 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] Resultado = SumarMatrices(matriz_1, matriz_2);
        ImprimirMatriz(Resultado);
    }

    static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int filas = matriz_1.GetLength(0);
        int columnas = matriz_1.GetLength(1);
        int[,] Resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Resultado[i, j] = matriz_1[i, j] + matriz_2[i, j];
            }
        }

        return Resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}