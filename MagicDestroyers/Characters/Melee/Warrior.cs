﻿using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();


        public Warrior()
            : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        { 
        }

        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.HEALTH_POINT)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.Faction = Consts.Warrior.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Execute()
        {
            return base.Weapon.DamagePoints + 12;
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}
