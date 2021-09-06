using System;

namespace ejercicio1
{
    class Empleado
    {
        // Atributos
        private string nombre;
        private string documento_empleado;
        private string telefono;
        private string email;
        private int salario_mensual;
        private int gastos_mensuales;
        // Constructores
        public Empleado()
        {
            Console.WriteLine("Se ha obtenido el nombre y el documento del empleado, se mostrara el total de dinero disponible");
        }
        // Set y get 
        public string Nombre
        {
            get { return this.nombre;}
            set { this.nombre = value;}

        }
        public string Document
        {
            get { return this.documento_empleado;}
            set { this.documento_empleado = value;}
        }
        public string Telefono
        {
            get { return this.telefono;}
            set { this.telefono = value;}
        }
        public string Email
        {
            get { return this.email;}
            set { this.email = value;}
        }
        public int Salario_m
        {
            get { return this.salario_mensual;}
            set { this.salario_mensual = value;}
        }
        public int Gastos_m
        {
            get { return this.gastos_mensuales;}
            set { this.gastos_mensuales = value;}
        }
        // Metodos
        public int total_dinero()
        {
            return this.salario_mensual - this.gastos_mensuales;
        }
    }
}