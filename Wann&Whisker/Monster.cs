using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wann_Whiskey
{
    public class Monster
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string DifficultyLvl { get; set; }
        public int Health { get; set; }
        public string Species { get; set; }
        public int Strength { get; set; }


        public Monster(string name, string type, string difficultylvl, int health, string species, int strength)
        {
            Name = name;
            Type = type;
            DifficultyLvl = difficultylvl;
            Health = health;
            Species = species;
            Strength = strength;
        }
    }
}