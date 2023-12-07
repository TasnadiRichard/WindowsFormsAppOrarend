namespace WindowsFormsAppOrarend
{
    partial class FormModositas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_megerosites = new System.Windows.Forms.Button();
            this.numericUpDown_sorszam = new System.Windows.Forms.NumericUpDown();
            this.textBox_oraid = new System.Windows.Forms.TextBox();
            this.textBox_tantargy = new System.Windows.Forms.TextBox();
            this.comboBox_hetnapja = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_hetnapja);
            this.groupBox1.Controls.Add(this.button_megerosites);
            this.groupBox1.Controls.Add(this.textBox_tantargy);
            this.groupBox1.Controls.Add(this.numericUpDown_sorszam);
            this.groupBox1.Controls.Add(this.textBox_oraid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Módosítások";
            // 
            // button_megerosites
            // 
            this.button_megerosites.Location = new System.Drawing.Point(12, 116);
            this.button_megerosites.Name = "button_megerosites";
            this.button_megerosites.Size = new System.Drawing.Size(75, 23);
            this.button_megerosites.TabIndex = 1;
            this.button_megerosites.Text = "Megerősítés";
            this.button_megerosites.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_sorszam
            // 
            this.numericUpDown_sorszam.Location = new System.Drawing.Point(224, 34);
            this.numericUpDown_sorszam.Name = "numericUpDown_sorszam";
            this.numericUpDown_sorszam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_sorszam.TabIndex = 2;
            // 
            // textBox_oraid
            // 
            this.textBox_oraid.Location = new System.Drawing.Point(12, 34);
            this.textBox_oraid.Name = "textBox_oraid";
            this.textBox_oraid.Size = new System.Drawing.Size(100, 20);
            this.textBox_oraid.TabIndex = 3;
            // 
            // textBox_tantargy
            // 
            this.textBox_tantargy.Location = new System.Drawing.Point(118, 34);
            this.textBox_tantargy.Name = "textBox_tantargy";
            this.textBox_tantargy.Size = new System.Drawing.Size(100, 20);
            this.textBox_tantargy.TabIndex = 4;
            // 
            // comboBox_hetnapja
            // 
            this.comboBox_hetnapja.FormattingEnabled = true;
            this.comboBox_hetnapja.Location = new System.Drawing.Point(350, 34);
            this.comboBox_hetnapja.Name = "comboBox_hetnapja";
            this.comboBox_hetnapja.Size = new System.Drawing.Size(121, 21);
            this.comboBox_hetnapja.TabIndex = 5;
            // 
            // FormModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 182);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormModositas";
            this.Text = "FormModositas";
            this.Load += new System.EventHandler(this.FormModositas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_megerosites;
        private System.Windows.Forms.NumericUpDown numericUpDown_sorszam;
        private System.Windows.Forms.TextBox textBox_oraid;
        private System.Windows.Forms.TextBox textBox_tantargy;
        private System.Windows.Forms.ComboBox comboBox_hetnapja;
    }
}