//using MagicDestroyers.Enums;
//using MagicDestroyers.Equipment.Armors.Heavy;
//using MagicDestroyers.Equipment.Weapons.Blunt;

//namespace MagicDestroyers.Characters.Melee
//{
//    public class Knight : Melee
//    {
//        private const string DEFAULT_NAME = "Legolas";
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_HEALTH_POINT = 100;
//        private const Faction DEFAULT_FACTION = Faction.Melee;
//        private const int DEFAULT_ABILITY_POINTS = 110;

//        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
//        private readonly Hammer DEFAULT_WEAPON = new Hammer();


//        public Knight()
//            : this(DEFAULT_NAME, DEFAULT_LEVEL)
//        {
//        }

//        public Knight(string name, int level)
//            : this(name, level, DEFAULT_HEALTH_POINT)
//        {
//        }

//        public Knight(string name, int level,int healthPoints)
//        {
//            base.Name = name;
//            base.Level = level;
//            base.HealthPoints = healthPoints;
//            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
//            base.Faction = DEFAULT_FACTION;
//            base.BodyArmor = DEFAULT_BODY_ARMOR;
//            base.Weapon = DEFAULT_WEAPON;
//        }

//        public void HolyBlow()
//        {
//            throw new NotImplementedException();
//        }

//        public void PuryfySoul()
//        {
//            throw new NotImplementedException();
//        }

//        public void RighteousWings()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            this.HolyBlow();
//        }

//        public override void SpecialAttack()
//        {
//            this.PuryfySoul();
//        }

//        public override void Defend()
//        {
//            this.RighteousWings();
//        }
//    }


//}
