using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.setNombre("Pedro");
            estudiante.setNota1(2);
            estudiante.setNota2(1.5);
            estudiante.setNota3(3);
            Console.WriteLine("*****************************");
            Console.WriteLine($"Estudiante {estudiante.getNombre()} {estudiante.nota_total()}");
            Console.WriteLine($"*****************************");
            Estudiante estudiante2 = new Estudiante("Maria");
            estudiante2.setNota1(2.9);
            estudiante2.setNota2(3.5);
            estudiante2.setNota3(4);
            Console.WriteLine("*****************************");
            Console.WriteLine($"Estudiante {estudiante2.getNombre()} {estudiante2.nota_total()}");
            Console.WriteLine($"*****************************");
            Estudiante estudiante3 = new Estudiante(4.5,3,5);
            estudiante3.setNombre("Jose");
            Console.WriteLine("*****************************");
            Console.WriteLine($"Estudiante {estudiante3.getNombre()} {estudiante3.nota_total()}");
            Console.WriteLine($"*****************************");
            Estudiante estudiante4 = new Estudiante("Susan", 3.6,2.1,1.6);
            Console.WriteLine("*****************************");
            Console.WriteLine($"Estudiante {estudiante4.getNombre()} {estudiante4.nota_total()}");
            Console.WriteLine($"*************************");
            Estudiante estudiante5 = new Estudiante("Charmander", 3, 2.5,2.7);
            Console.WriteLine("*****************************");
            Console.WriteLine($"Estudiante {estudiante5.getNombre()} {estudiante5.nota_total()}");
        }
    }
}
