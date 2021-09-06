using System;

namespace ejercicio3
{
    class Estudiante
    {
        // Argumentos
        private string nombre;
        
        private double nota1;
        
        private double nota2;
        
        private double nota3;
        
        // Atributos
        public Estudiante()
        {
            Console.WriteLine("Estos son los resultados de los siguientes estudiantes");
        }

        public Estudiante(string nombre)
        {
            this.nombre = nombre;
        }

        public Estudiante(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public Estudiante(string nombre, double nota1, double nota2, double nota3)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        
        // Funciones set y get
        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string value)
        {
            this.nombre = value;
        }

        public double getNota1()
        {
            return this.nota1;
        }

        public void setNota1(double value)
        {
            this.nota1 = value;
        }

        public double getNota2()
        {
            return this.nota2;
        }

        public void setNota2(double value)
        {
            this.nota2 = value;
        }

        public double getNota3()
        {
            return this.nota3;
        }

        public void setNota3(double value)
        {
            this.nota3 = value;
        }

        // Metodos
        public string nota_total()
        {
            double suma_nota = nota1 + nota2 + nota3;
            double total = suma_nota / 3;
            if(total > 3.5)
            {
                return $"Aprobo con {total}";
            }
            else
            {
                return $"No aprobo con {total}";
            }
        }
    }
}