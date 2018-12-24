namespace Pol_Combat_Pseudo_Sim
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.charColdTextBox = new System.Windows.Forms.TextBox();
            this.charFireTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.charArTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.charIntTextBox = new System.Windows.Forms.TextBox();
            this.charDexTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charStrTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skillValueTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.charPoiTextBox = new System.Windows.Forms.TextBox();
            this.charEneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enemyPoiTextBox = new System.Windows.Forms.TextBox();
            this.enemyEneTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.enemyColdTextBox = new System.Windows.Forms.TextBox();
            this.enemyFireTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.enemyArTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.enemyIntTextBox = new System.Windows.Forms.TextBox();
            this.enemyDexTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.enemyStrTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.enemySkillValueTextBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(208, 149);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weapon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.charPoiTextBox);
            this.groupBox2.Controls.Add(this.charEneTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.charColdTextBox);
            this.groupBox2.Controls.Add(this.charFireTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.charArTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.charIntTextBox);
            this.groupBox2.Controls.Add(this.charDexTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.charStrTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.skillValueTextBox);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(239, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character";
            // 
            // charColdTextBox
            // 
            this.charColdTextBox.Location = new System.Drawing.Point(150, 95);
            this.charColdTextBox.Name = "charColdTextBox";
            this.charColdTextBox.Size = new System.Drawing.Size(43, 20);
            this.charColdTextBox.TabIndex = 15;
            this.charColdTextBox.TextChanged += new System.EventHandler(this.charColdTextBox_TextChanged);
            // 
            // charFireTextBox
            // 
            this.charFireTextBox.Location = new System.Drawing.Point(150, 69);
            this.charFireTextBox.Name = "charFireTextBox";
            this.charFireTextBox.Size = new System.Drawing.Size(43, 20);
            this.charFireTextBox.TabIndex = 14;
            this.charFireTextBox.TextChanged += new System.EventHandler(this.charFireTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "COLD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "FIRE:";
            // 
            // charArTextBox
            // 
            this.charArTextBox.Location = new System.Drawing.Point(150, 44);
            this.charArTextBox.Name = "charArTextBox";
            this.charArTextBox.Size = new System.Drawing.Size(43, 20);
            this.charArTextBox.TabIndex = 11;
            this.charArTextBox.TextChanged += new System.EventHandler(this.charArTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AR:";
            // 
            // charIntTextBox
            // 
            this.charIntTextBox.Location = new System.Drawing.Point(45, 95);
            this.charIntTextBox.Name = "charIntTextBox";
            this.charIntTextBox.Size = new System.Drawing.Size(43, 20);
            this.charIntTextBox.TabIndex = 9;
            this.charIntTextBox.TextChanged += new System.EventHandler(this.charIntTextBox_TextChanged);
            // 
            // charDexTextBox
            // 
            this.charDexTextBox.Location = new System.Drawing.Point(45, 69);
            this.charDexTextBox.Name = "charDexTextBox";
            this.charDexTextBox.Size = new System.Drawing.Size(43, 20);
            this.charDexTextBox.TabIndex = 8;
            this.charDexTextBox.TextChanged += new System.EventHandler(this.charDexTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "INT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEX:";
            // 
            // charStrTextBox
            // 
            this.charStrTextBox.Location = new System.Drawing.Point(45, 44);
            this.charStrTextBox.Name = "charStrTextBox";
            this.charStrTextBox.Size = new System.Drawing.Size(43, 20);
            this.charStrTextBox.TabIndex = 5;
            this.charStrTextBox.TextChanged += new System.EventHandler(this.charStrTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "STR:";
            // 
            // skillValueTextBox
            // 
            this.skillValueTextBox.Location = new System.Drawing.Point(140, 19);
            this.skillValueTextBox.Name = "skillValueTextBox";
            this.skillValueTextBox.Size = new System.Drawing.Size(53, 20);
            this.skillValueTextBox.TabIndex = 3;
            this.skillValueTextBox.TextChanged += new System.EventHandler(this.skillValueTextBox_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // charPoiTextBox
            // 
            this.charPoiTextBox.Location = new System.Drawing.Point(150, 147);
            this.charPoiTextBox.Name = "charPoiTextBox";
            this.charPoiTextBox.Size = new System.Drawing.Size(43, 20);
            this.charPoiTextBox.TabIndex = 19;
            this.charPoiTextBox.TextChanged += new System.EventHandler(this.charPoiTextBox_TextChanged);
            // 
            // charEneTextBox
            // 
            this.charEneTextBox.Location = new System.Drawing.Point(150, 121);
            this.charEneTextBox.Name = "charEneTextBox";
            this.charEneTextBox.Size = new System.Drawing.Size(43, 20);
            this.charEneTextBox.TabIndex = 18;
            this.charEneTextBox.TextChanged += new System.EventHandler(this.charEneTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "POI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ENE :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.enemyPoiTextBox);
            this.groupBox3.Controls.Add(this.enemyEneTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.enemyColdTextBox);
            this.groupBox3.Controls.Add(this.enemyFireTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.enemyArTextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.enemyIntTextBox);
            this.groupBox3.Controls.Add(this.enemyDexTextBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.enemyStrTextBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.enemySkillValueTextBox);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Location = new System.Drawing.Point(239, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 202);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enemy";
            // 
            // enemyPoiTextBox
            // 
            this.enemyPoiTextBox.Location = new System.Drawing.Point(150, 147);
            this.enemyPoiTextBox.Name = "enemyPoiTextBox";
            this.enemyPoiTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyPoiTextBox.TabIndex = 19;
            this.enemyPoiTextBox.TextChanged += new System.EventHandler(this.enemyPoiTextBox_TextChanged);
            // 
            // enemyEneTextBox
            // 
            this.enemyEneTextBox.Location = new System.Drawing.Point(150, 121);
            this.enemyEneTextBox.Name = "enemyEneTextBox";
            this.enemyEneTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyEneTextBox.TabIndex = 18;
            this.enemyEneTextBox.TextChanged += new System.EventHandler(this.enemyEneTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "POI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "ENE :";
            // 
            // enemyColdTextBox
            // 
            this.enemyColdTextBox.Location = new System.Drawing.Point(150, 95);
            this.enemyColdTextBox.Name = "enemyColdTextBox";
            this.enemyColdTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyColdTextBox.TabIndex = 15;
            this.enemyColdTextBox.TextChanged += new System.EventHandler(this.enemyColdTextBox_TextChanged);
            // 
            // enemyFireTextBox
            // 
            this.enemyFireTextBox.Location = new System.Drawing.Point(150, 69);
            this.enemyFireTextBox.Name = "enemyFireTextBox";
            this.enemyFireTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyFireTextBox.TabIndex = 14;
            this.enemyFireTextBox.TextChanged += new System.EventHandler(this.enemyFireTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "COLD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "FIRE:";
            // 
            // enemyArTextBox
            // 
            this.enemyArTextBox.Location = new System.Drawing.Point(150, 44);
            this.enemyArTextBox.Name = "enemyArTextBox";
            this.enemyArTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyArTextBox.TabIndex = 11;
            this.enemyArTextBox.TextChanged += new System.EventHandler(this.enemyArTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "AR:";
            // 
            // enemyIntTextBox
            // 
            this.enemyIntTextBox.Location = new System.Drawing.Point(45, 95);
            this.enemyIntTextBox.Name = "enemyIntTextBox";
            this.enemyIntTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyIntTextBox.TabIndex = 9;
            this.enemyIntTextBox.TextChanged += new System.EventHandler(this.enemyIntTextBox_TextChanged);
            // 
            // enemyDexTextBox
            // 
            this.enemyDexTextBox.Location = new System.Drawing.Point(45, 69);
            this.enemyDexTextBox.Name = "enemyDexTextBox";
            this.enemyDexTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyDexTextBox.TabIndex = 8;
            this.enemyDexTextBox.TextChanged += new System.EventHandler(this.enemyDexTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "INT:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "DEX:";
            // 
            // enemyStrTextBox
            // 
            this.enemyStrTextBox.Location = new System.Drawing.Point(45, 44);
            this.enemyStrTextBox.Name = "enemyStrTextBox";
            this.enemyStrTextBox.Size = new System.Drawing.Size(43, 20);
            this.enemyStrTextBox.TabIndex = 5;
            this.enemyStrTextBox.TextChanged += new System.EventHandler(this.enemyStrTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "STR:";
            // 
            // enemySkillValueTextBox
            // 
            this.enemySkillValueTextBox.Location = new System.Drawing.Point(140, 19);
            this.enemySkillValueTextBox.Name = "enemySkillValueTextBox";
            this.enemySkillValueTextBox.Size = new System.Drawing.Size(53, 20);
            this.enemySkillValueTextBox.TabIndex = 3;
            this.enemySkillValueTextBox.TextChanged += new System.EventHandler(this.enemySkillValueTextBox_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(127, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 202);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulation";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 46);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(208, 149);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 480);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pol-Combat-Pseudo-Sim";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox charColdTextBox;
        private System.Windows.Forms.TextBox charFireTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox charArTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox charIntTextBox;
        private System.Windows.Forms.TextBox charDexTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox charStrTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox skillValueTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox charPoiTextBox;
        private System.Windows.Forms.TextBox charEneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox enemyPoiTextBox;
        private System.Windows.Forms.TextBox enemyEneTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox enemyColdTextBox;
        private System.Windows.Forms.TextBox enemyFireTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox enemyArTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox enemyIntTextBox;
        private System.Windows.Forms.TextBox enemyDexTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox enemyStrTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox enemySkillValueTextBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

