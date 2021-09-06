using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* La escuela Ignacio Barrera, desea que le desarrolles un juego para sus alumnos de primaria. El juego
se llama "cuadro mágico", un cuadro mágico es aquel en que la suma de cada fila, la suma de cada
columna y la suma de las diagonales es exactamente igual. El cuadro mágico es de dos dimensiones.
Desarrollar un programa que pida al usuario las dimensiones deseadas para el cuadro mágico (un
arreglo de dos dimensiones) en forma de cuadro y luego le pida los datos para llenar el arreglo.
Después el programa debe calcular la suma de cada fila, de cada columna y de cada diagonal del


cuadro, si todas las sumas son iguales entonces le deberás de indicar por medio de un mensaje
"Felicidades creaste un cuadro mágico", de lo contrario le deberás de decir el siguiente mensaje:
"Modifica los números en el cuadro para que lo hagas mágico".
Como resultado de la ejecución del programa, además del mensaje correspondiente, deberás mostrar en
pantalla el arreglo de entrada (el cuadro), la suma de cada renglón y la suma de cada columna.*/
            int filas, columnas;
            Console.WriteLine("Ingrese el tamaño del cuadro magico (2x2, 3x3, etc), solo un numero");
            _ = int.TryParse(Console.ReadLine(), out int Clength);

            filas = Clength;
            columnas = Clength;

            int[] sumaFilas = new int[filas];
            int[] sumaColum = new int[columnas];

            int[,] cuadroMagico = new int[filas, columnas];
            int sumaTotalFila = 0;
            int sumaTotalColum = 0;

            for(int i = 0; i < filas; i++) {
                for(int j = 0; j < columnas; j++) {
                    Console.WriteLine("Ingrese el valor: ");
                    _ = int.TryParse(Console.ReadLine(), out cuadroMagico[i,j]);
                }
            }

            for(int i = 0; i < filas; i++) {
                sumaTotalFila = 0;
                for(int j = 0; j < columnas; j++) {
                    sumaTotalFila += cuadroMagico[i,j];
                }
                sumaFilas[i] = sumaTotalFila;
            }

            int k = 0;
            do {
                sumaTotalColum = 0;
                for(int i = 0; i < filas; i++) {
                    sumaTotalColum += cuadroMagico[i,k];
                }
                sumaColum[k] = sumaTotalColum;
                k++;
            } while(k < filas);

            int sumaTotalDiag = 0;
            int sumaDiag = 0;
            
            int m = 0, n = 0;
            do {
                for(int i = 0; i < filas; i++) {
                    sumaTotalDiag += cuadroMagico[m,n];
                    m++;
                    n++;
                }
                sumaDiag += sumaTotalDiag;
            } while(m < filas);
            

            int fila = sumaFilas[0];
            int colum = sumaColum[0];
            string estadoF = "", estadoC = "", estadoD = "";

            Console.WriteLine("Filas: ");
            foreach(int item in sumaFilas) {
                Console.WriteLine($"Total: {item}");
                if(fila == item) {
                    estadoF = "ok";
                }
                else {
                    estadoF = "No";
                    break;
                }
            }

            Console.WriteLine("Columnas: ");
            foreach(int item in sumaColum) {
                Console.WriteLine($"Total: {item}");
                if(colum == item) {
                    estadoC = "ok";
                }
                else {
                    estadoC = "No";
                    break;
                }
            }

            Console.WriteLine("Cuadro magico: ");
            for(int i = 0; i < Clength; i++) {
                for(int j = 0; j < Clength; j++)  {
                    Console.Write(cuadroMagico[i,j]);
                }
                Console.WriteLine(" ");
            }

            if(sumaDiag == fila) {
                estadoD = "ok";
            }
            else {
                estadoD = "No";
            }

            if(estadoF == "ok" && estadoC == "ok" && estadoD == "ok") {
                Console.WriteLine("Felicidades!!! Creaste un cuadro magico");
            }
            else {
                Console.WriteLine("Lastima :c vuelve a ingresar los valores para crear un cuadro magico");
            }

        }
    }
}
