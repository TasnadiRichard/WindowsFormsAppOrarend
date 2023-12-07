namespace WindowsFormsAppOrarend
{
    partial class FormTanarbelepes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_felhasznalonev = new System.Windows.Forms.TextBox();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.button_bejelentkezes = new System.Windows.Forms.Button();
            this.button_regisztracio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(160, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // textBox_felhasznalonev
            // 
            this.textBox_felhasznalonev.Location = new System.Drawing.Point(12, 58);
            this.textBox_felhasznalonev.Name = "textBox_felhasznalonev";
            this.textBox_felhasznalonev.Size = new System.Drawing.Size(100, 20);
            this.textBox_felhasznalonev.TabIndex = 2;
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(138, 58);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(100, 20);
            this.textBox_jelszo.TabIndex = 3;
            // 
            // button_bejelentkezes
            // 
            this.button_bejelentkezes.Location = new System.Drawing.Point(12, 98);
            this.button_bejelentkezes.Name = "button_bejelentkezes";
            this.button_bejelentkezes.Size = new System.Drawing.Size(100, 23);
            this.button_bejelentkezes.TabIndex = 4;
            this.button_bejelentkezes.Text = "Bejelentkezés";
            this.button_bejelentkezes.UseVisualStyleBackColor = true;
            // 
            // button_regisztracio
            // 
            this.button_regisztracio.Location = new System.Drawing.Point(138, 98);
            this.button_regisztracio.Name = "button_regisztracio";
            this.button_regisztracio.Size = new System.Drawing.Size(100, 22);
            this.button_regisztracio.TabIndex = 5;
            this.button_regisztracio.Text = "Regisztráció";
            this.button_regisztracio.UseVisualStyleBackColor = true;
            // 
            // FormTanarbelepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 189);
            this.Controls.Add(this.button_regisztracio);
            this.Controls.Add(this.button_bejelentkezes);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.textBox_felhasznalonev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTanarbelepes";
            this.Text = "Formtanarok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_felhasznalonev;
        private System.Windows.Forms.TextBox textBox_jelszo;
        private System.Windows.Forms.Button button_bejelentkezes;
        private System.Windows.Forms.Button button_regisztracio;
    }
}