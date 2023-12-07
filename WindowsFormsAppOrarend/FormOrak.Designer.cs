namespace WindowsFormsAppOrarend
{
    partial class FormOrak
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
            this.listBox_tanarok = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_orarend = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_uj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_modositas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_torles = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_megerosites = new System.Windows.Forms.Button();
            this.textBox_oraid = new System.Windows.Forms.TextBox();
            this.comboBox_tantargy = new System.Windows.Forms.ComboBox();
            this.numericUpDown_sorszam = new System.Windows.Forms.NumericUpDown();
            this.comboBox_nap = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_tanarok
            // 
            this.listBox_tanarok.FormattingEnabled = true;
            this.listBox_tanarok.Location = new System.Drawing.Point(0, 27);
            this.listBox_tanarok.Name = "listBox_tanarok";
            this.listBox_tanarok.Size = new System.Drawing.Size(120, 212);
            this.listBox_tanarok.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_orarend});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_orarend
            // 
            this.toolStripMenuItem_orarend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_uj,
            this.ToolStripMenuItem_modositas,
            this.ToolStripMenuItem_torles});
            this.toolStripMenuItem_orarend.Name = "toolStripMenuItem_orarend";
            this.toolStripMenuItem_orarend.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem_orarend.Text = "Órarend";
            // 
            // ToolStripMenuItem_uj
            // 
            this.ToolStripMenuItem_uj.Name = "ToolStripMenuItem_uj";
            this.ToolStripMenuItem_uj.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_uj.Text = "Új";
            // 
            // ToolStripMenuItem_modositas
            // 
            this.ToolStripMenuItem_modositas.Name = "ToolStripMenuItem_modositas";
            this.ToolStripMenuItem_modositas.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_modositas.Text = "Módosítás";
            // 
            // ToolStripMenuItem_torles
            // 
            this.ToolStripMenuItem_torles.Name = "ToolStripMenuItem_torles";
            this.ToolStripMenuItem_torles.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_torles.Text = "Törlés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(126, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Óra ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(126, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tantárgy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(129, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sorszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(129, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nap";
            // 
            // button_megerosites
            // 
            this.button_megerosites.Location = new System.Drawing.Point(0, 260);
            this.button_megerosites.Name = "button_megerosites";
            this.button_megerosites.Size = new System.Drawing.Size(197, 37);
            this.button_megerosites.TabIndex = 6;
            this.button_megerosites.Text = "Megerősítés";
            this.button_megerosites.UseVisualStyleBackColor = true;
            // 
            // textBox_oraid
            // 
            this.textBox_oraid.Location = new System.Drawing.Point(218, 36);
            this.textBox_oraid.Name = "textBox_oraid";
            this.textBox_oraid.Size = new System.Drawing.Size(100, 20);
            this.textBox_oraid.TabIndex = 7;
            // 
            // comboBox_tantargy
            // 
            this.comboBox_tantargy.FormattingEnabled = true;
            this.comboBox_tantargy.Location = new System.Drawing.Point(218, 65);
            this.comboBox_tantargy.Name = "comboBox_tantargy";
            this.comboBox_tantargy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tantargy.TabIndex = 8;
            // 
            // numericUpDown_sorszam
            // 
            this.numericUpDown_sorszam.Location = new System.Drawing.Point(218, 100);
            this.numericUpDown_sorszam.Name = "numericUpDown_sorszam";
            this.numericUpDown_sorszam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_sorszam.TabIndex = 9;
            // 
            // comboBox_nap
            // 
            this.comboBox_nap.FormattingEnabled = true;
            this.comboBox_nap.Location = new System.Drawing.Point(218, 132);
            this.comboBox_nap.Name = "comboBox_nap";
            this.comboBox_nap.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nap.TabIndex = 10;
            // 
            // FormOrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_nap);
            this.Controls.Add(this.numericUpDown_sorszam);
            this.Controls.Add(this.comboBox_tantargy);
            this.Controls.Add(this.textBox_oraid);
            this.Controls.Add(this.button_megerosites);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_tanarok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrak";
            this.Text = "FormOrak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_tanarok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_orarend;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_uj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modositas;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_torles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_megerosites;
        private System.Windows.Forms.TextBox textBox_oraid;
        private System.Windows.Forms.ComboBox comboBox_tantargy;
        private System.Windows.Forms.NumericUpDown numericUpDown_sorszam;
        private System.Windows.Forms.ComboBox comboBox_nap;
    }
}