using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hacer un algoritmo que almacene números en una matriz de 5 * 6. Imprimir la suma de los números
            almacenados en la matriz.*/

            int[,] matrizInicial = {{1,2,3,4,5,6}, {7,8,9,1,2,3}, {1,2,3,4,5,6}, {7,8,9,1,2,3},{1,2,3,4,5,6} };
            int suma = 0;

            for(int i = 0; i < 5; i++){
                for(int j = 0; j < 6; j++) {
                    suma += matrizInicial[i,j];
                }
            }

            Console.WriteLine("La suma total es: " + suma);
        }
    }
}
