using System;

namespace ejercicio1
{
    class Numero 
    {
        public int cantNum { get; set; }

        public Numero(int numero)
        {
            this.cantNum = numero;
        }

        public void logicNum()
        {
            int mayorCero = 0;
            int[] numero = new int[this.cantNum];

            for(int i = 0; i < this.cantNum; i++)
            {
                Console.WriteLine("Ingrese el valor: " + (i + 1));
                _ = int.TryParse(Console.ReadLine(), out numero[i]);
            }

            foreach(int i in numero)
            {
                if(i > 0)
                {
                    Console.WriteLine("El numero es: " + i);
                    mayorCero++;
                }
            }
            Console.WriteLine("La cantidad de numeros mayores a cero es: " + mayorCero);
        }
    }
}