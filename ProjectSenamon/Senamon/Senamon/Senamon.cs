
namespace Senamon
{
    public class Senamon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string TypeSenamon { get; set; }
        public float Weight { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Phase { get; set; }
        public int Energy { get; set; }
        public string Description { get; set; }

        public Senamon(string name, int lvl, string type, float weight, int health, int attack, int phase, string description)
        {
            this.Name = name;
            this.Level = lvl;
            this.TypeSenamon = type;
            this.Weight = weight;
            this.Health = health;
            this.Attack = attack;
            this.Phase = phase;
            this.Description = description;
        }
    }
}