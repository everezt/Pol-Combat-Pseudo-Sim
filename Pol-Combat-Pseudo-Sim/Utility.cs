using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Pol_Combat_Pseudo_Sim
{
    public static class Utility
    {
        public static class Parser
        {
            public static string[] ReadUseableLinesFromFile(string path)
            {
                string[] lines = File.ReadAllLines(path);
                var useableLines = (from line in lines where !line.StartsWith("#") &&
                                    !line.StartsWith("/") && !line.StartsWith("\t/") &&
                                    !line.StartsWith("\t#") &&
                                    !String.IsNullOrWhiteSpace(line) select line).ToArray<string>();
                return useableLines;
            }        
        }
    }
}
