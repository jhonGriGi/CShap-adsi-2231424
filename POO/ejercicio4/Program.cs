using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] lista_estudiantes = new Estudiante[5];
            Estudiante estudiante = new Estudiante("Pedro", 2,1.5,3);
            Estudiante estudiante2 = new Estudiante("Maria", 2.9,3.5,4);
            Estudiante estudiante3 = new Estudiante("Jose", 4.5,3.5,5);
            Estudiante estudiante4 = new Estudiante("Susan", 3.6, 2.1,1.6);
            Estudiante estudiante5 = new Estudiante("Charmander", 3.5, 3, 4);
            lista_estudiantes[0] = estudiante;
            lista_estudiantes[1] = estudiante2;
            lista_estudiantes[2] = estudiante3;
            lista_estudiantes[3] = estudiante4;
            lista_estudiantes[4] = estudiante5;
            Console.WriteLine("*****************************");
            Console.WriteLine($"El estudiante {lista_estudiantes[0].nombre} {lista_estudiantes[0].resultado()}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"El estudiante {lista_estudiantes[1].nombre} {lista_estudiantes[1].resultado()}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"El estudiante {lista_estudiantes[2].nombre} {lista_estudiantes[2].resultado()}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"El estudiante {lista_estudiantes[3]} {lista_estudiantes[3].resultado()}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"El estudiante {lista_estudiantes[4].nombre} {lista_estudiantes[4].resultado()}");
            Console.WriteLine("*****************************");
        }
    }
}
