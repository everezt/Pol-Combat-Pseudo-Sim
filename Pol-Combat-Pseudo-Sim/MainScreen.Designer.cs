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
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Pol-Combat-Pseudo-Sim";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

