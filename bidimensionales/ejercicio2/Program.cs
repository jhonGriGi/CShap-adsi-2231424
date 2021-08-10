using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un algoritmo que llene una matriz de 10 * 10 y determine la posición [fila, columna] del número
            mayor almacenado en la matriz. Los números son diferentes.*/

            // inicializando la matriz
            Console.WriteLine("Ingrese el numero de filas");
            _ = int.TryParse(Console.ReadLine(), out int filas);
            Console.WriteLine("Ingrese el numero de columnas");
            _ = int.TryParse(Console.ReadLine(), out int columnas);
            int[,] matrizInicial = new int[filas, columnas];

            //Ingresando los datos 
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el valor");
                    _ = int.TryParse(Console.ReadLine(), out matrizInicial[i, j]);
                }
            }


            // busqueda del mayor valor
            int busquedaX = 0, busquedaY = 0;
            int mayorValor = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (mayorValor < matrizInicial[i, j])
                    {
                        mayorValor = matrizInicial[i, j];
                        busquedaX = i;
                        busquedaY = j;
                    }
                }
            }
            Console.WriteLine("El mayor valor es: " + mayorValor);
            Console.WriteLine("En la posicion [" + busquedaX + ", " + busquedaY + "] de la matriz");
        }
    }
}
