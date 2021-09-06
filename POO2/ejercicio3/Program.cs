using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, documento, telefono, email;
            double salario, gastos;
            Empleado empleado = new Empleado();

            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();

            empleado.Nombre = nombre;

            Console.WriteLine("Cual es tu documento?");
            documento = Console.ReadLine();

            empleado.Document = documento;

            Console.WriteLine("Cual es tu telefono?");
            telefono = Console.ReadLine();

            empleado.Telefono = telefono;

            Console.WriteLine("Cual es tu email?");
            email = Console.ReadLine();

            empleado.Email = email;

            Console.WriteLine("Cual es tu salario?");
            _ = double.TryParse(Console.ReadLine(), out salario);

            empleado.Salario_m = salario;

            Console.WriteLine("Cuales son tus gastos?");
            _ = double.TryParse(Console.ReadLine(), out gastos);

            Console.WriteLine("Estos son tus datos");
            Console.WriteLine($"    >>>>Nombre: {empleado.Nombre}");
            Console.WriteLine($"    >>>>Documento: {empleado.Document}");
            Console.WriteLine($"    >>>>Telefono: {empleado.Telefono}");
            Console.WriteLine($"    >>>>Email: {empleado.Email}");
            Console.WriteLine("*****************************");
            Console.WriteLine("Dinero disponible:");
            Console.WriteLine($"    >>>>Dinero: {empleado.total_dinero(salario, gastos)}");
            
        }
    }
}
