using System;
using System.Collections.Generic;

namespace recuperacion
{
    class ControlBattle
    {
        public List<Senamon> senamons = new List<Senamon>();
        
        public ControlBattle() {}

        public void battleTeam(int select1, int select2, int select3, int select4, int select5)
        {
            int opcion1 = select1 - 1,
                opcion2 = select2 - 1,
                opcion3 = select3 - 1,
                opcion4 = select4 - 1,
                opcion5 = select5 - 1;
            
            AsignamentSenamon asignamentSenamon = new AsignamentSenamon();

            asignamentSenamon.asignamentSenamon();

            if (opcion1 > 0 && opcion1 < asignamentSenamon.GetListSenamon().Count
                            && opcion2 > 0 && opcion2 < asignamentSenamon.GetListSenamon().Count
                            && opcion3 > 0 && opcion3 < asignamentSenamon.GetListSenamon().Count
                            && opcion4 > 0 && opcion4 < asignamentSenamon.GetListSenamon().Count
                            && opcion5 > 0 && opcion5 < asignamentSenamon.GetListSenamon().Count)
            {
                senamons.Add(asignamentSenamon.GetListSenamon()[opcion1]);
                senamons.Add(asignamentSenamon.GetListSenamon()[opcion2]);
                senamons.Add(asignamentSenamon.GetListSenamon()[opcion3]);
                senamons.Add(asignamentSenamon.GetListSenamon()[opcion4]);
                senamons.Add(asignamentSenamon.GetListSenamon()[opcion5]);
            }
        }

        public List<Senamon> GetBattleTeam()
        {
            return this.senamons;
        }
    }
}