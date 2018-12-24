using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol_Combat_Pseudo_Sim
{
    class Npc
    {
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Intelligence { get; set; }
        public double Armor { get; set; }
        public double FireResist { get; set; }
        public double ColdResist { get; set; }
        public double EneResist { get; set; }
        public double PosResist { get; set; }


        public Dictionary<string, double> Skills = new Dictionary<string, double>();

        public Npc(double str, double dex, double inte, double ar, double fire, double cold, double ene, double pos)
        {
            this.Strength = str;
            this.Dexterity = dex;
            this.Intelligence = inte;

            this.Armor = ar;
            this.FireResist = fire;
            this.ColdResist = cold;
            this.EneResist = ene;
            this.PosResist = pos;

            Skills["Anatomy"] = 115.0d;
            Skills["Macefighting"] = 115.0d;
            Skills["Swordmanship"] = 115.0d;
            Skills["Fencing"] = 115.0d;
            Skills["Archery"] = 115.00;
            Skills["Parry"] = 115.0d;
            Skills["Tactics"] = 115.0d;
        }

        public string GetSkillValue(string skillName)
        {
            foreach (var skill in Skills)
            {
                if (skill.Key.ToString() == skillName)
                {
                    return skill.Value.ToString();
                }
            }
            return "Not found";
        }
    }
}
