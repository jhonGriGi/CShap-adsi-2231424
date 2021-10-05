using System;

namespace ejercicio3
{
    class Vacuna
    {
        private string nombreVacuna;

        private string fechaAplicacion;

        private int numeroDosis;

        private string descripcionVacuna;

        // get y set 
        public string NombreVacuna
        {
            get { return this.nombreVacuna; }
            set { this.nombreVacuna = value; }
        }

        public string FechaAplicacion
        {
            get { return this.fechaAplicacion; }
            set { this.fechaAplicacion = value; }
        }

        public int NumeroDosis
        {
            get { return this.numeroDosis; }
            set { this.numeroDosis = value; }
        }

        public string DescripcionVacuna
        {
            get { return this.descripcionVacuna; }
            set { this.descripcionVacuna = value; }
        }
    }
}