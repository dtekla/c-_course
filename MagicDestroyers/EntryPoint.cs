using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Characters;

namespace MagicDestroyers 
{
    class EntryPoint 
    {
        static void Main()
        {
            Random rng = new Random();

            //Mage myMage = new Mage();
            //Console.WriteLine("my mage is {0}", myMage);
            //Console.WriteLine($"my mage is {myMage}");

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            { 
                new Warrior(),
                new Warrior(),
                new Warrior(),
      
                new Mage(),
                new Mage(),
                new Mage(),

                //new Knight(),
                //new Assassin(),
                //new Necromancer(),
                //new Druid(),
            };


            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                { 
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name);

                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.wonBattle();

                    spellTeam.Remove(currentSpellcaster);

                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    { 
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];  
                    }

                }

                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.wonBattle();

                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcaster team wins!");
                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }

                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name);
            }

        }
    }
}
