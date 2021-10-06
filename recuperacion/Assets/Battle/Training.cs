using System;
using System.Collections.Generic;

namespace recuperacion
{
    public class Training
    {
        public Training() {}
        ControlBattle controlBattle = new ControlBattle();
        private Entrenador _entrenador = new Entrenador();

        public void Entrenamiento()
        {
            

            
        }

        public int TrainingHealth(int entrenador, int opcion)
        {
            return _entrenador.GetVectSenamon()[opcion].Health + 20;
        }

        public int TrainingAttack(int entrenador, int opcion)
        {
            return _entrenador.GetVectSenamon()[opcion].Attack + 20;
        }

    }
}