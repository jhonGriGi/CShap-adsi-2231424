using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un algoritmo que llene una matriz de 10 * 10 y determine la posición [fila, columna] del número
            mayor almacenado en la matriz. Los números son diferentes.*/

            int[,] mayorValor = {{2,4}, {10, 50}}; // Resultado 2,2
            int length = mayorValor.Length, condicional = 0;
            int[] numeroMayor = new int[length];
            
            for(int i = 0; i < 2; i++) {
                for(int j = 0; j < 2; j++) {
                    if(mayorValor[i,j] > condicional) {
                        numeroMayor = mayorValor[i,j];
                    }
                }
            }

            Console.WriteLine("El mayor valor se encuentra en: " + numeroMayor);
        }
    }
}
