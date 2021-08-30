using System;

namespace ejercicio4
{
    class Estudiante
    {
        public string nombre { get; set;}
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set;}
        public Estudiante(string nombre, double nota1, double nota2, double nota3)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        public string resultado()
        {
            double suma_total = this.nota1 + this.nota2 + this.nota3;
            double total = suma_total / 3;
            
           if(total >= 3.5)
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