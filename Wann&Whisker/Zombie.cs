
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wann_Whiskey
{
    class Zombie : Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public string TypeZombie { get; set; }

        public Zombie(string name, int health, string typezombie) : base(health)
        {
            Name = name;
            TypeZombie = typezombie;
        }
    }

}
