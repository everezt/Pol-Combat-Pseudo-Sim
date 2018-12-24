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

        }
    }
}
