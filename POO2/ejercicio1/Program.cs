using System;

namespace ejercicio1
{
    class Program
    {
        static void Maint(string[] args)
        {
            int num;
            int mayorCero = 0;

            Console.WriteLine("Ingrese la cantidad de numeros que va a ingresar");
            _ = int.TryParse(Console.ReadLine(), out num);

            int[] numeros = new int[num];

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Ingrese el numero de " + (i + 1));
                _ = int.TryParse(Console.ReadLine(), out numeros[i]);
            }

            foreach(int i in numeros)
            {
                if(i > 0)
                {
                    Console.WriteLine("El numero es: " + i);
                    mayorCero++;
                }
            }

            Console.WriteLine("La cantidad de numeros mayores a cero son: " + mayorCero);
        }
    }
}
