
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Wann_Whiskey
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Position CurrPosition { get; set; }
        public float MovementSpeed { get; set; }
        public Cat Whiskers { get; set; }

        public string WeaponType {  get; set; }

        public Player(string name, int health, Position position, float movementSpeed, Cat whiskers, string weaponType)
        {
            Name = name;
            Health = health;
            CurrPosition = position;
            MovementSpeed = movementSpeed;
            Whiskers = whiskers;
            WeaponType = weaponType;
        }
    }
}
