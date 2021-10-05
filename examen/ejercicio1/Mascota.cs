using System;


namespace ejercicio1
{
    class Mascota
    {
        private string nombre;

        private int edad;

        private string tipoMascota;

        private string raza;

        private double peso;

        private string color;

        private bool esterilizado;

        private string codigoMascota;

        // Constructores
        public Mascota() {}


        // Metodos set y get 
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public string TipoMascota
        {
            get { return this.tipoMascota; }
            set { this.tipoMascota = value; }
        }

        public string Raza 
        {
            get { return this.raza; }
            set { this.raza = value; }
        }

        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public bool Esterilizado
        {
            get { return this.esterilizado; }
            set { this.esterilizado = value; }
        }

        public string getCodigoMastoca
        {
            get { return this.codigoMascota; }
            set { this.codigoMascota = value; }
        }

        // Metodos set

        public void CodigoMascota(int value) 
        {
            Random rnd = new Random();
            int valorAzar = rnd.Next(10000, 1000000);

            if ( value == 1)
            {
                this.codigoMascota = $"P - {valorAzar}";
                this.tipoMascota = "Perro";
            }
            else if ( value == 2 ) 
            {
                this.codigoMascota = $"G - {valorAzar}";
                this.tipoMascota = "Gato";
            }
        }
    }
}