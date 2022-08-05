//using MagicDestroyers.Enums;
//using MagicDestroyers.Equipment.Armors.Leather;
//using MagicDestroyers.Equipment.Weapons.Sharp;

//namespace MagicDestroyers.Characters.Melee
//{
//    public class Assassin : Melee
//    {
//        private const string DEFAULT_NAME = "Butcher";
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_HEALTH_POINT = 120;
//        private const Faction DEFAULT_FACTION = Faction.Melee;
//        private const int DEFAULT_ABILITY_POINTS = 100;

//        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
//        private readonly Sword DEFAULT_WEAPON = new Sword();

//        public Assassin()
//            : this (DEFAULT_NAME, DEFAULT_LEVEL)
//        {
//        }
//        public Assassin(string name, int level)
//            :this(name, level, DEFAULT_HEALTH_POINT)
//        {
//        }
//        public Assassin(string name,int level, int healthPoints)
//        {
//            base.Name = name; 
//            base.Level = level;
//            base.HealthPoints = healthPoints;
//            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
//            base.Faction = DEFAULT_FACTION;
//            base.BodyArmor = DEFAULT_BODY_ARMOR;
//            base.Weapon = DEFAULT_WEAPON;
           
//        }

//        public void Raze()
//        {
//            throw new NotImplementedException();
//        }

//        public void BleedToDeath()
//        {
//            throw new NotImplementedException();
//        }

//        public void Survival()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            this.Raze();
//        }

//        public override void SpecialAttack()
//        {
//            this.BleedToDeath();
//        }

//        public override void Defend()
//        {
//            this.Survival();
//        }
//    }
//}
