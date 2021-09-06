using System;

namespace ejercicio2
{
    class Empleado
    {
        // Atributos
        public string nombre {get; set;}
        public string documento {get; set;}

        public int precio_horas {get; set;}

        public int cantidad_horas {get; set;}
        // Constructores
        public Empleado() 
        {
            Console.WriteLine("Se mostraran los sueldos de 3 empleados");
        }

        public Empleado(string nombre, string documento)
        {
            this.nombre = nombre;
            this.documento = documento;
        }

        public Empleado(int precio_horas, int cantidad_horas)
        {
            this.precio_horas = precio_horas;
            this.cantidad_horas = cantidad_horas;
        }
        // Metodos
        public int salario_total()
        {
            return this.cantidad_horas * this.precio_horas;
        }
    }
}