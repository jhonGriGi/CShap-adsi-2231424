using System;
using System.Collections.Generic;

namespace recuperacion
{
    class AsignamentSenamon
    {
        public List<Senamon> listSenamon = new List<Senamon>();


        public void asignamentSenamon()
        {
            Senamon senamon = new Senamon("Bulbasaur", 1, "Planta", 6.9f, 45, 49, 1);
            listSenamon.Add(senamon);
            senamon = new Senamon("Venusaur", 1, "Planta", 100.0f, 80, 82, 3);
            listSenamon.Add(senamon);
        }


        public List<Senamon> GetListSenamon()
        {
            return this.listSenamon;
        }
    }
}