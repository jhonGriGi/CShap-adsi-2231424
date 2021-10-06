using System;

namespace recuperacion
{
    class Entrenador
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { get; set; }
        public int WonBattles { get; set; }

        public Senamon[] vectSenamon = new Senamon[5];

        public Entrenador()
        {
            
        }

        public Senamon[] GetVectSenamon()
        {
            return this.vectSenamon;
        }

        public void SetVectSenamon(Senamon senamon)
        {
            for (int i = 0, length = this.vectSenamon.Length; i < length; i++)
            {
                if (vectSenamon[i] == null)
                {
                    vectSenamon[i] = senamon;
                    break;
                }
            }
        }
    }
}