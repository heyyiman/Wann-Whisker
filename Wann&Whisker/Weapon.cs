using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wann_Whiskey;

namespace project_oop
{
    class Weapon : Player
    {
        public string WeaponName { get; set; }
        public string WeaponType { get; set; }
        public int Ammo { get; set; }
        public float Range { get; set; }
        public float FireRate { get; set; }
        public float AttackRate { get; set; }
        public float ReloadTime { get; set; }

        public Weapon(string weaponName, string weaponType, int ammo, float range, float fireRate, float attackRate, float reloadTime)
        {
            WeaponName = weaponName;
            WeaponType = weaponType;
            Ammo = ammo;
            Range = range;
            FireRate = fireRate;
            AttackRate = attackRate;
            ReloadTime = reloadTime;
        }


    }
}