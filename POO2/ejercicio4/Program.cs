using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente();

            paciente.Name = "john";
            paciente.Surname = "GRISALES";
            paciente.Gender = "hombre";
            paciente.Document = "13921312";
            paciente.Age = 25;
            paciente.Eps = "Chanchito feliz";
            paciente.Blood = "O+";

            Console.WriteLine("Estos son los datos del paciente registrado.");
            Console.WriteLine("    >>>>Nombre: " + paciente.Name);
            Console.WriteLine("    >>>>Apellido: " + paciente.Surname);
            Console.WriteLine("    >>>>Genero: " + paciente.Gender);
            Console.WriteLine("    >>>>Edad: " + paciente.Age);
            Console.WriteLine("    >>>>Documento: " + paciente.Document);
            Console.WriteLine("    >>>>Eps: " + paciente.Eps);
            Console.WriteLine("    >>>>Blood: " + paciente.Blood);
            Console.WriteLine("*****************************");
            Console.WriteLine("EL paciente es hombre mayor de edad: " + paciente.IsMen());
            Console.WriteLine("*****************************");
            Console.WriteLine("El codigo de paciente es: ");
            Console.WriteLine(paciente.getCodigo());
            Console.WriteLine("*****************************");


            Paciente paciente_2 = new Paciente("Alfred", "Wayne", "hombre", "230231231", 78);
            paciente_2.Eps = "gotham";
            paciente_2.Blood = "A+";

            Console.WriteLine("Estos son los datos del paciente registrado.");
            Console.WriteLine("    >>>>Nombre: " + paciente_2.Name);
            Console.WriteLine("    >>>>Apellido: " + paciente_2.Surname);
            Console.WriteLine("    >>>>Genero: " + paciente_2.Gender);
            Console.WriteLine("    >>>>Edad: " + paciente_2.Age);
            Console.WriteLine("    >>>>Documento: " + paciente_2.Document);
            Console.WriteLine("    >>>>Eps: " + paciente_2.Eps);
            Console.WriteLine("    >>>>Blood: " + paciente_2.Blood);
            Console.WriteLine("*****************************");
            Console.WriteLine("EL paciente es hombre mayor de edad: " + paciente_2.IsMen());
            Console.WriteLine("*****************************");
            Console.WriteLine("El codigo de paciente 2 es: ");
            Console.WriteLine(paciente_2.getCodigo());
            Console.WriteLine("*****************************");

            Paciente paciente_3 = new Paciente("Alicia", "Rodriguez", "Mujer", "231312312", "O+", 28, "Chanchito Feliz 2");

            Console.WriteLine("Estos son los datos del paciente registrado.");
            Console.WriteLine("    >>>>Nombre: " + paciente_3.Name);
            Console.WriteLine("    >>>>Apellido: " + paciente_3.Surname);
            Console.WriteLine("    >>>>Genero: " + paciente_3.Gender);
            Console.WriteLine("    >>>>Edad: " + paciente_3.Age);
            Console.WriteLine("    >>>>Documento: " + paciente_3.Document);
            Console.WriteLine("    >>>>Eps: " + paciente_3.Eps);
            Console.WriteLine("    >>>>Blood: " + paciente_3.Blood);
            Console.WriteLine("*****************************");
            Console.WriteLine("EL paciente es hombre mayor de edad: " + paciente_3.IsMen());
            Console.WriteLine("*****************************");
            Console.WriteLine("El codigo de paciente 3 es: ");
            Console.WriteLine(paciente_3.getCodigo());
            Console.WriteLine("*****************************");
        }
    }
}
