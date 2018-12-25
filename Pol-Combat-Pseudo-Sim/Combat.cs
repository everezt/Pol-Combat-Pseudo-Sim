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
        public const double HitRateMod = 1.00d;

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
            //hit_chance = (weapon_attribute + 50.0) / (2.0 * opponent_weapon_attribute + 50.0)
            string skillUsed = weapon["Attribute"];
            double defenderSkill = defender.Skills[skillUsed];
            double attackerSkill = attacker.Skills[skillUsed];

            double hitChance = HitRateMod * ((attackerSkill + 50.0d) / (2.0d * defenderSkill + 50));

            return true; // unfinished
        }

        public static bool IsParry(Npc defender)
        {
            double currSkill = defender.Skills["Parry"];

            int randomChance = (int)(currSkill / 4);
            int randomDice = Utility.Dice.Roll("1d100");

            if (currSkill >= 100.00)
            {
                randomChance += 5;
            }

            if (currSkill <= 0.00)
            {
                currSkill = 1;
            }

            if (randomDice < randomChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string GetApproxAttackSpeed(Npc attacker, Dictionary<string, string> weapon)
        {
            /*
                Attack speed :
                Attack speed formula
                15000 /( (dexterity + 100)* weaponspeed)
                A dexterity of 140 and a weaponspeed of 35 means ever 1.78s a attack
            */

            return String.Format("Attack delay => {0:0.##}s", Math.Round( 15000 / ( ( attacker.Dexterity + 100) * int.Parse(weapon["Speed"] ) ), 2).ToString());

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
