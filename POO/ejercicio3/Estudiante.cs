using System;

namespace ejercicio3
{
    class Estudiante
    {
        private string nombre;
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string value)
        {
            this.nombre = value;
        }
        private double nota1;
        public double getNota1()
        {
            return this.nota1;
        }
        public void setNota1(double value)
        {
            this.nota1 = value;
        }
        private double nota2;
        public double getNota2()
        {
            return this.nota2;
        }
        public void setNota2(double value)
        {
            this.nota2 = value;
        }
        private double nota3;
        public double getNota3()
        {
            return this.nota3;
        }
        public void setNota3(double value)
        {
            this.nota3 = value;
        }
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
        public string nota_total()
        {
            double suma_nota = nota1 + nota2 + nota3;
            double total = suma_nota / 3;
            if(total > 3.5)
            {
                return $"El estudiante aprobo con {total}";
            }
            else
            {
                return $"El estudiante no aprobo con {total}";
            }
        }
    }
}