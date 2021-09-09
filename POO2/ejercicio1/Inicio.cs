using System;

namespace ejercicio1
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int limitNum;

            Console.WriteLine("Ingrese la cantidad de numeros");
            _ = int.TryParse(Console.ReadLine(), out limitNum);

            Numero numero = new Numero(limitNum);
            numero.logicNum();
            numero.showNum();
        }
    }
}
