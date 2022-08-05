

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Hammer()
            :this(DEFAULT_DAMAGE_POINTS)
        {
        
        }

        public Hammer(int armorPoints)
        {
            base.DamagePoints = armorPoints;
        }

        public void Stun() 
        { 
            throw new NotImplementedException();
        }
    }
}
