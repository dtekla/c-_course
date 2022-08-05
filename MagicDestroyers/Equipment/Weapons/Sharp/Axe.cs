

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        { 
        }

        public Axe(int armorPoints)
        {
            base.DamagePoints = armorPoints;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
