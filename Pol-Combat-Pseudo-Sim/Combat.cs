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
        public const double HitRateMod = 0.25d;

        public enum FacingFrom
        {
            Back,
            Front,
            Side,
            Unknown
        }

        public static bool IsCritical(Npc attacker)
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

        public static bool IsHit(Npc attacker, Npc defender, Dictionary<string, string> weapon)
        {
            string skillUsed = weapon["Attribute"];
            double defenderSkill = defender.Skills[skillUsed];
            double attackerSkill = attacker.Skills[skillUsed];

            double hitChance = HitRateMod * ( ( (attackerSkill + double.Parse(weapon["SkillRequired"])) / HitRateMod ) - defenderSkill);

            return true; // unfinished
        }

        public static int GetExtraDamageFromStrMod(Npc attacker, Dictionary<string, string> weapon)
        {
            double damagePrecentage = 0.00;
            double str = attacker.Strength;
            double weaponBaseDamage = Utility.Dice.Roll(weapon["Damage"]);

            damagePrecentage = str / 6;

            if (damagePrecentage > 25.00d)
            {
                damagePrecentage = 25.00d;
            }

            return int.Parse((weaponBaseDamage + (damagePrecentage / 100 * weaponBaseDamage)).ToString());
        }

        
    }
}
