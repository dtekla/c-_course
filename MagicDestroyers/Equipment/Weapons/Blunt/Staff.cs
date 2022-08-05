

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 10; 
        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        { 
        }

        public Staff(int armorPoints)
        {
            base.DamagePoints = armorPoints;
        }

        public void Empower()
        { 
            throw new NotImplementedException();
        }
    }
}
