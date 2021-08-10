using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
    /*La compañía manufacturera Monte Real fábrica 5 artículos diferentes y se trabajan tres turnos por
        día, la compañía necesita obtener un reporte al final del día del total de la producción por artículo y
        el total de la producción por turno. Desarrollar un programa que pida al usuario el nombre de cada
        artículo y la producción que se hizo en cada uno de los tres turnos del día y genere un reporte al final
        del día mostrado en pantalla el total de de la producción por artículo, el total de la producción por
        turno y el artículo con mayor producción.

        Articulo \ Turno Turno 1 Turno 2 Turno 3
        Articulo 1         30      40      20
        Articulo 2         10      12      15
        Articulo 3         8       10      7
        Articulo 4         25      30      30
        Articulo 5         12      20      10 */
        
            Console.WriteLine("Cuantos articulos desea incluir?");
            _ = int.TryParse(Console.ReadLine(), out int cantArticulos);

            string[] nombreArticulo = new string[cantArticulos];
            int[,] produccion = new int[cantArticulos, 3];

            for(int i = 0; i < cantArticulos; i++) {
                Console.WriteLine($"Ingrese el nombre del articulo {i+1}");
                nombreArticulo[i] = Console.ReadLine();

                for(int j = 0; j < 3; j++) {
                    Console.WriteLine($"Ingrese la produccion del turno {j+1}");
                    _ = int.TryParse(Console.ReadLine(), out produccion[i,j]);
                }
            }

            int sumaProduccion = 0;
            string nombreMayorPro = "";
            int mayorProduccion = 0;
            for(int i = 0; i < cantArticulos; i++){
                for(int j = 0; j < 3; j++) {
                    sumaProduccion += produccion[i,j];
                }
                if(sumaProduccion > mayorProduccion) {
                    nombreMayorPro = nombreArticulo[i];
                    mayorProduccion = sumaProduccion;
                }
                Console.WriteLine($"El total de produccion del articulo {nombreArticulo[i]} es: {sumaProduccion}");
                sumaProduccion = 0;
            }

            int k = 0, l = 0, n = 0;
            int produccionTurno1 = 0, produccionTurno2 = 0, produccionTurno3 = 0;

            while(k < cantArticulos){
                produccionTurno1 += produccion[k,0];
                k++;
            }
            while(l < cantArticulos) {
                produccionTurno2 += produccion[l,1];
                l++;
            }
            while(n < cantArticulos) {
                produccionTurno3 += produccion[n,2];
                n++;
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine($"El turno uno tiene una produccion de {produccionTurno1}");
            Console.WriteLine($"El turno dos tiene una produccion de {produccionTurno2}");
            Console.WriteLine($"El turno tres tiene una produccion de {produccionTurno3}");

            Console.WriteLine("******************************************************");
            Console.WriteLine($"El producto con mayor produccion es: {nombreMayorPro} con un total de {mayorProduccion}");
        }
    }
}
