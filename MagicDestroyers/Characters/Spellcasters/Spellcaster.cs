

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abilityPoint {value} is not correct");
                }
            }
        }
    }
}
