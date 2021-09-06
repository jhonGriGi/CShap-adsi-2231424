using System;

namespace ejercicio3
{
    class Empleado
    {
        // Atributos
        private string nombre;
        private string documento_empleado;
        private string telefono;
        private string email;
        private double salario_mensual;
        private double gastos_mensuales;
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
        public double Salario_m
        {
            get { return this.salario_mensual;}
            set { this.salario_mensual = value;}
        }
        public double Gastos_m
        {
            get { return this.gastos_mensuales;}
            set { this.gastos_mensuales = value;}
        }
        // Metodos
        public double total_dinero(double salario, double gastos)
        {
            return salario - gastos;
        }
    }
}