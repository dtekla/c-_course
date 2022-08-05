
using MagicDestroyers.Enums;
using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        private int healthPoints;
        private int level;
        private int scores;

        private string name;

        private Faction faction;

        private Weapon weapon;
        private Armor bodyArmor;

        private bool isAlive;

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set 
            {
                this.isAlive = value;
            }

        }

        public virtual int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abilityPoint {value} is not correct");
                }
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abilityPoint {value} is not correct");
                }
            }
        }

        public int Scores
        {
            get 
            {
                return this.scores;
            }
            set 
            {
                this.scores = value;

            }
        }

        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;

            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.IsAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha you are weak");
            }

            if (!this.IsAlive)
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName} , and is now dead!");
            }
            else 
            {
                Console.WriteLine($"{this.name} received {damage} from {attackerName} damage, and is has {this.healthPoints} healthpoints");
            }
        }

        public void wonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
