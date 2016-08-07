﻿using System.Collections.Generic;
using Core.Enum;
using Core.WeaponProperties;

namespace Core.Weapons.Requests
{
    public class InsertWeaponRequest
    {
        public string Name { get; set; }
        public WeaponType WeaponType { get; set; }
        public int NumberOfDice { get; set; }
        public Dice DamageDice { get; set; }
        public decimal Cost { get; set; }                               //in gold
        public string CriticalThreatRange { get; set; }
        public int CriticalMultiplier { get; set; }
        public int Range { get; set; }                                  //in feet
        public decimal Weight { get; set; }                                 //in lbs
        public IEnumerable<WeaponDamageType> DamageType { get; set; }
        public IEnumerable<WeaponProperty> Properties { get; set; }
    }
}