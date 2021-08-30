using System;

namespace ejercicio1
{
    class Empleado
    {
        /* Realizar la clase empleado con los métodos necesarios y los siguientes atributos:
        documento_empleado, nombre, teléfono, email, salario_mensual y gastos_mensuales.
        Declarar 3 instancias de la clase empleado con cada uno de los atributos e indicar cuánto es
        el dinero total disponible del empleado (realizar un método que realice este cálculo)*/
        private string nombre;

        public string Nombre
        {
            get { return this.nombre;}
            set { this.nombre = value;}

        }

        private string documento_empleado;
        
        public string Document
        {
            get { return this.documento_empleado;}
            set { this.documento_empleado = value;}
        }

        private string telefono;

        public string Telefono
        {
            get { return this.telefono;}
            set { this.telefono = value;}
        }

        private string email;

        public string Email
        {
            get { return this.email;}
            set { this.email = value;}
        }

        private int salario_mensual;

        public int Salario_m
        {
            get { return this.salario_mensual;}
            set { this.salario_mensual = value;}
        }

        private int gastos_mensuales;

        public int Gastos_m
        {
            get { return this.gastos_mensuales;}
            set { this.gastos_mensuales = value;}
        }

        public Empleado()
        {
            Console.WriteLine("Se ha obtenido el nombre y el documento del empleado, se mostrara el total de dinero disponible");
        }

        public int total_dinero()
        {
            return this.salario_mensual - this.gastos_mensuales;
        }
    }
}