using System;

namespace ejercicio2
{
    class Jugador
    {
        // Atributos
        private string _nombre;

        private string _nivel;

        private string _tipoDeJuego;

        private int _edad;

        private int _horasDeJuego;

        // Constructores
        public Jugador()
        {
            Console.WriteLine("Hola Jugador quiero conocer un poco de ti!!!!");
        }

        // getters y setters
        public string getNombre()
        {
            return this._nombre;
        }
        
        public void setNombre(string value)
        {
            this._nombre = value;
        }

        public string getNivel()
        {
            return this._nivel;
        }

        public void setNivel(string value)
        {
            this._nivel = value;
        }

        public string getTipoDeJuego()
        {
            return this._tipoDeJuego;
        }

        public void setTipoDeJuego(string value)
        {
            this._tipoDeJuego = value;
        }

        public int getEdad()
        {
            return this._edad;
        }

        public void setEdad(int value)
        {
            this._edad = value;
        }

        public int getHorasDeJuego()
        {
            return this._horasDeJuego;
        }

        public void setHorasDeJuego(int value)
        {
            this._horasDeJuego = value;
        }

        // Metodos 
        public double promedio(int victorias, int derrotas)
        {
            int sumaTotal = victorias + derrotas;

            return sumaTotal / 2;
        }
    }
}