
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Wann_Whisker;

namespace Wann_Whiskey
{
    public class Cat : Player
    {

        public string Whisker { get; set; }
        public Position CurrPosition { get; set; }


        public Cat(string whisker, int health, Position position, float movementSpeed)
        {
            Whisker = whisker;
            Health = health;
            CurrPosition = position;
            MovementSpeed = movementSpeed;

        }
    }
}
