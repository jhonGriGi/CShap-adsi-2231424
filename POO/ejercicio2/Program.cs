using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.nombre = "Darwin";
            empleado.documento = "102401210";
            empleado.precio_horas = 5000;
            empleado.cantidad_horas = 38;
            Console.WriteLine("****************************************************************");
            Console.WriteLine($"El empleado {empleado.nombre} con documento {empleado.documento} tiene un salario mensual de: {empleado.salario_total()}");
            Console.WriteLine("****************************************************************");
            Empleado empleado_2 = new Empleado("Pikachu", "02313013");
            empleado_2.precio_horas = 6000;
            empleado_2.cantidad_horas = 40;
            Console.WriteLine("****************************************************************");
            Console.WriteLine($"El empleado {empleado_2.nombre} con documento {empleado_2.documento} tiene un salario mensual de: {empleado_2.salario_total()}");
            Console.WriteLine("****************************************************************");
            Empleado empleado_3 = new Empleado(4600, 48);
            empleado_3.nombre = "Charmander";
            empleado_3.documento = "5312301231";
            Console.WriteLine("****************************************************************");
            Console.WriteLine($"El empleado {empleado_3.nombre} con documento {empleado_3.documento} tiene un salario mensual de: {empleado_3.salario_total()}");
            Console.WriteLine("****************************************************************");
        }
    }
}
