using System;
using System.Collections.Generic;

namespace recuperacion
{
    class ControlBattle
    {
        public List<Senamon> senamons = new List<Senamon>();
        public List<Entrenador> entrenadores = new List<Entrenador>();
        public List<Senamon> TeamSenamons = new List<Senamon>();
        private Senamon[] equipo = new Senamon[2];
        
        public ControlBattle() {}

        // se asignan los senamones al equipo de combate 
        public void BattleTeam(int select1, int select2, int select3, int select4, int select5)
        {
            int opcion1 = select1 - 1,
                opcion2 = select2 - 1,
                opcion3 = select3 - 1,
                opcion4 = select4 - 1,
                opcion5 = select5 - 1;

            
            AsignamentSenamon asignamentSenamon = new AsignamentSenamon();

            asignamentSenamon.asignamentSenamon();

            // if (opcion1 > 0 && opcion1 < asignamentSenamon.GetListSenamon().Count
            //                 && opcion2 > 0 && opcion2 < asignamentSenamon.GetListSenamon().Count
            //                 && opcion3 > 0 && opcion3 < asignamentSenamon.GetListSenamon().Count
            //                 && opcion4 > 0 && opcion4 < asignamentSenamon.GetListSenamon().Count
            //                 && opcion5 > 0 && opcion5 < asignamentSenamon.GetListSenamon().Count)
            // {
            //     senamons.Add(asignamentSenamon.GetListSenamon()[opcion1]);
            //     senamons.Add(asignamentSenamon.GetListSenamon()[opcion2]);
            //     senamons.Add(asignamentSenamon.GetListSenamon()[opcion3]);
            //     senamons.Add(asignamentSenamon.GetListSenamon()[opcion4]);
            //     senamons.Add(asignamentSenamon.GetListSenamon()[opcion5]);
            // }

            // Senamon[] vectSenamon = {asignamentSenamon.GetListSenamon()[opcion1], 
            //     asignamentSenamon.GetListSenamon()[opcion2], 
            //     asignamentSenamon.GetListSenamon()[opcion3], 
            //     asignamentSenamon.GetListSenamon()[opcion4], 
            //     asignamentSenamon.GetListSenamon()[opcion5]};
            
            senamons.Add(asignamentSenamon.GetListSenamon()[opcion1]);
            senamons.Add(asignamentSenamon.GetListSenamon()[opcion2]);
            senamons.Add(asignamentSenamon.GetListSenamon()[opcion3]);
            senamons.Add(asignamentSenamon.GetListSenamon()[opcion4]);
            senamons.Add(asignamentSenamon.GetListSenamon()[opcion5]);

            // Senamon[] vectSenamon = {senamons};

            // senamons.Add(vectSenamon);
            // SetTeamSenamon(senamons);
            for (int i = 0, length = this.entrenadores.Count; i < length; i++)
            {
                equipo[i] = this.senamons;
            }

            Entrenador entrenador = new Entrenador();

            foreach (var senamon in senamons)
            {
                entrenador.SetVectSenamon(senamon);
            }
        }

        // public List<Senamon> GetTeamSenamon()
        // {
        //     return this.TeamSenamons;
        // }
        // public void SetTeamSenamon(List<Senamon> senamons)
        // {
        //     this.TeamSenamons.Add(senamons);
        // }

        public List<Senamon> GetBattleTeam()
        {
            return this.senamons;
        }

        public void SetListEntrenadores(Entrenador entrenador)
        {
            this.entrenadores.Add(entrenador);
        }

        public List<Entrenador> GetListEntrenadores()
        {
            return this.entrenadores;
        }
    }
}