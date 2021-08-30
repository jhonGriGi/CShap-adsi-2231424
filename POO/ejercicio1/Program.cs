using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Darwin";
            empleado.Document = "03235454";
            empleado.Telefono = "+57 321551341";
            empleado.Email = "test@example.com";
            empleado.Salario_m = 50000;
            empleado.Gastos_m = 30000;
            Console.WriteLine($"El empleado {empleado.Nombre} con documento: {empleado.Document} tiene un total de:");
            Console.WriteLine(empleado.total_dinero());
            
        }
    }
}
