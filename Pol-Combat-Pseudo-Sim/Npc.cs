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

            Skills["Anatomy"] = 105.00d;
            Skills["Macefighting"] = 105.00d;
            Skills["Swordmanship"] = 105.00d;
            Skills["Fencing"] = 105.00d;
            Skills["Archery"] = 105.00d;
            Skills["Parry"] = 105.00d;
            Skills["Tactics"] = 105.00d;
        }
    }
}
