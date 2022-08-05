//using MagicDestroyers.Enums;
//using MagicDestroyers.Equipment.Armors.Leather;
//using MagicDestroyers.Equipment.Weapons.Sharp;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MagicDestroyers.Characters.Spellcasters
//{
//    public class Necromancer : Spellcaster
//    {
//        private const string DEFAULT_NAME = "Dwane";
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_HEALTH_POINT = 105;
//        private const Faction DEFAULT_FACTION = Faction.SpellSpellcasters;
//        private const int DEFAULT_ABILITY_POINTS = 85;

//        private readonly LightLeatherVest DEFAULT_BODY_ARMOR  = new LightLeatherVest();
//        private readonly Sword DEFAULT_WEAPON = new Sword();

//        public Necromancer()
//            : this(DEFAULT_NAME, DEFAULT_LEVEL)
//        {
//        }
//        public Necromancer(string name, int level)
//            : this(name, level, DEFAULT_HEALTH_POINT)
//        {
//        }
//        public Necromancer(string name, int level, int healthPoints)
//        {
//            base.Name = name;
//            base.Level = level;
//            base.HealthPoints = healthPoints;
//            base.ManaPoints = DEFAULT_ABILITY_POINTS;
//            base.Faction = DEFAULT_FACTION;
//            base.BodyArmor = DEFAULT_BODY_ARMOR;
//            base.Weapon = DEFAULT_WEAPON;

//        }

//        public void ShadowRage()
//        {
//            throw new NotImplementedException();
//        }

//        public void VampireTouch()
//        {
//            throw new NotImplementedException();
//        }

//        public void BoneShield()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            this.ShadowRage();
//        }

//        public override void SpecialAttack()
//        {
//            this.VampireTouch();
//        }

//        public override void Defend()
//        {
//            this.BoneShield();
//        }

//    }
//}
