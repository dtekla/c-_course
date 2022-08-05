

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Sword()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Sword(int armorPoints)
        {
            base.DamagePoints = armorPoints;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
