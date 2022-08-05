
namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abilityPoint {value} is not correct");
                }
            }
        }
    }
}
