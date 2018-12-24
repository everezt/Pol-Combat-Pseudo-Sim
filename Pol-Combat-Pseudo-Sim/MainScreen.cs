using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pol_Combat_Pseudo_Sim
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        Npc char1;
        Npc enemy;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Item desc file | itemdesc.cfg";

            if (DialogResult.OK == file.ShowDialog())
            {
                try
                {
                    Items.LoadItems(Utility.Parser.ReadUseableLinesFromFile(file.FileName));

                    for(int i = 0; i < Items.items.Count(); i++)
                    {
                        comboBox1.Items.Add(Items.items[i]["Name"]);

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> item = Items.GetItem(comboBox1.Text);

            string output = "";

            foreach (var KeyVal in item)
            {
                output += string.Format("{0} => {1}\n", KeyVal.Key, KeyVal.Value);
            }

            //output += "\n\n\n" + Items.GetItemValue(comboBox1.Text, "Desc");

            richTextBox1.Text = output;

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            char1 = new Npc(140, 120, 10, 40, 50, 0, 0, 50);
            enemy = new Npc(1000, 200, 300, 100, 200, 20, 20, 20);

            foreach (var skill in char1.Skills)
            {
                comboBox2.Items.Add(skill.Key);
                comboBox3.Items.Add(skill.Key);
            }

            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            charArTextBox.Text = char1.Armor.ToString();
            charFireTextBox.Text = char1.FireResist.ToString();
            charEneTextBox.Text = char1.EneResist.ToString();
            charPoiTextBox.Text = char1.PosResist.ToString();
            charColdTextBox.Text = char1.ColdResist.ToString();
            charStrTextBox.Text = char1.Strength.ToString();
            charDexTextBox.Text = char1.Dexterity.ToString();
            charIntTextBox.Text = char1.Intelligence.ToString();


            enemyArTextBox.Text = enemy.Armor.ToString();
            enemyFireTextBox.Text = enemy.FireResist.ToString();
            enemyEneTextBox.Text = enemy.EneResist.ToString();
            enemyPoiTextBox.Text = enemy.PosResist.ToString();
            enemyColdTextBox.Text = enemy.ColdResist.ToString();
            enemyStrTextBox.Text = enemy.Strength.ToString();
            enemyDexTextBox.Text = enemy.Dexterity.ToString();
            enemyIntTextBox.Text = enemy.Intelligence.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            skillValueTextBox.Text = char1.GetSkillValue(comboBox2.Text);
        }

        public double checkDouble(ref TextBox skillTextBox)
        {
            try
            {
                double value;
                if (double.TryParse(skillTextBox.Text, out value))
                {
                    return value;
                }
                else
                {
                    skillTextBox.Text = skillTextBox.Text.Remove(skillTextBox.Text.Length - 1, 1);
                    skillTextBox.SelectionStart = skillTextBox.Text.Length;
                    skillTextBox.SelectionLength = 0;
                    return 0;
                }
            }    
            catch
            {
                return 0;
            }
        }

        private void skillValueTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.Skills[comboBox2.Text] = checkDouble(ref skillValueTextBox);
        }

        private void charStrTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.Strength = checkDouble(ref charStrTextBox);
        }

        private void charDexTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.Dexterity = checkDouble(ref charDexTextBox);
        }

        private void charIntTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.Intelligence = checkDouble(ref charIntTextBox);
        }

        private void charArTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.Armor = checkDouble(ref charArTextBox);
        }

        private void charFireTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.FireResist = checkDouble(ref charFireTextBox);
        }

        private void charColdTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.ColdResist = checkDouble(ref charColdTextBox);
        }

        private void charEneTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.EneResist = checkDouble(ref charColdTextBox);
        }

        private void charPoiTextBox_TextChanged(object sender, EventArgs e)
        {
            char1.PosResist = checkDouble(ref charPoiTextBox);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            enemySkillValueTextBox.Text = enemy.GetSkillValue(comboBox3.Text);
        }

        private void enemySkillValueTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.Skills[comboBox3.Text] = checkDouble(ref enemySkillValueTextBox);
        }

        private void enemyStrTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.Strength = checkDouble(ref enemyStrTextBox);
        }

        private void enemyDexTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.Dexterity = checkDouble(ref enemyDexTextBox);
        }

        private void enemyIntTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.Intelligence = checkDouble(ref enemyIntTextBox);
        }

        private void enemyArTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.Armor = checkDouble(ref enemyArTextBox);
        }

        private void enemyFireTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.FireResist = checkDouble(ref enemyFireTextBox);
        }

        private void enemyColdTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.ColdResist = checkDouble(ref enemyColdTextBox);
        }

        private void enemyEneTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.EneResist = checkDouble(ref enemyEneTextBox);
        }

        private void enemyPoiTextBox_TextChanged(object sender, EventArgs e)
        {
            enemy.PosResist = checkDouble(ref enemyPoiTextBox);
        }
    }
}
