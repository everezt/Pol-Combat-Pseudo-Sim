using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol_Combat_Pseudo_Sim
{
    static class Items
    {
        public static List<Dictionary<string, string>> items = new List<Dictionary<string, string>>();

        public static void LoadItems(string[] text)
        {
            bool isAnItem = false;

            Dictionary<string, string> item = new Dictionary<string, string>();

            for ( int i = 0; i < text.Length; i++)
            {     

                if (text[i].StartsWith("{"))
                {
                    item = new Dictionary<string, string>();
                    isAnItem = true;
                    string[] itemDict = text[i - 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    item.Add(itemDict[0], itemDict[1]);
                    continue;
                    
                }

                if (text[i].StartsWith("}"))
                {
                    isAnItem = false;
                    items.Add(item);
                }

                if (isAnItem)
                {
                    string[] attrAndValue = text[i].Split(new char[] { '\t', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);                   
                    if (attrAndValue.Count() >= 2)
                    {
                        
                        if (attrAndValue.Count() >= 3)
                        {
                            string key = attrAndValue[0];
                            string value = "";

                            for(int j = 1; j < attrAndValue.Count(); j++)
                            {
                                if (j == 1)
                                {
                                    value += attrAndValue[j];
                                }
                                else
                                {
                                    value += String.Format(" {0}", attrAndValue[j]);
                                }
                                
                            }

                            attrAndValue = new string[] { key, value };
                        }

                        try
                        {
                            item.Add(attrAndValue[0].Trim(), attrAndValue[1].Trim());
                        }
                        catch
                        {
                            item.Add(attrAndValue[0].Trim() + "_" + i, attrAndValue[1].Trim());
                        }
                        
                    }
                    
                }                       
            }          
        }

        public static Dictionary<string, string> GetItem(string itemName)
        {
            foreach (var item in items)
            {
                if (item["Name"] == itemName)
                {
                    return item;
                }
            }

            return null;
        }

        public static string GetItemValue(string itemName, string TKey)
        {
            foreach (var item in items)
            {
                if (item["Name"] == itemName)
                {
                    try
                    {
                        return item[TKey];
                    }
                    catch
                    {
                        return "Key not found!";
                    }
                }
            }
            return "Item not found!";
        }
    }
}
