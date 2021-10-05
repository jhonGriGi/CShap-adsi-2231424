using System;
using System.Collections.Generic;

namespace ejercicio3
{
    class Veterinaria
    {

        private List<Mascota> listaMascotas = new List<Mascota>();

        // Constructores

        public Veterinaria() {}

        // get y set get
        public List<Mascota> getListaMascota()
        {
            return this.listaMascotas;
        }

        public void setListaMacota(Mascota mascota)
        {
            this.listaMascotas.Add(mascota);
        }
    }
}