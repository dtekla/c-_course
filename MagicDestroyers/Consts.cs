using MagicDestroyers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers
{
     public static class Consts
     {
        public static class Warrior
        { 
            public const string NAME = "Spartacus";
            public const int LEVEL = 1;
            public const int HEALTH_POINT = 140;
            public const Faction FACTION = Faction.Melee;
            public const int ABILITY_POINTS = 130;
        }

        public static class Mage
        { 
            public const string NAME = "Selena";
            public const int LEVEL = 1;
            public const int HEALTH_POINT = 95;
            public const Faction FACTION = Enums.Faction.SpellSpellcasters;
            public const int ABILITY_POINTS = 80;
        }
     }
}
