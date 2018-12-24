using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol_Combat_Pseudo_Sim
{
    public static class Combat
    {
        public const double StrAPMod = 0.65d;
        public const double DexCritMod = 0.25d;

        public enum FacingFrom
        {
            Back,
            Front,
            Side,
            Unknown
        }

        public static bool isCritical(Npc attacker)
        {
            double critChance = 0;
            double skill = attacker.Skills["Tactics"];
            double stat = attacker.Dexterity;

            critChance = DexCritMod * ((skill / 5) + (stat / 6) * 2);

            if (Utility.Dice.Roll("1d100") >= critChance)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
