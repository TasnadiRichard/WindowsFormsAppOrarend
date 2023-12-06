namespace WindowsFormsAppOrarend
{
    partial class FormRegisztracio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisztracio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_felhasznalonev = new System.Windows.Forms.TextBox();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.button_regisztracio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(139, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // textBox_felhasznalonev
            // 
            this.textBox_felhasznalonev.Location = new System.Drawing.Point(12, 65);
            this.textBox_felhasznalonev.Name = "textBox_felhasznalonev";
            this.textBox_felhasznalonev.Size = new System.Drawing.Size(100, 20);
            this.textBox_felhasznalonev.TabIndex = 2;
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(133, 65);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(100, 20);
            this.textBox_jelszo.TabIndex = 3;
            // 
            // button_regisztracio
            // 
            this.button_regisztracio.Location = new System.Drawing.Point(12, 100);
            this.button_regisztracio.Name = "button_regisztracio";
            this.button_regisztracio.Size = new System.Drawing.Size(100, 23);
            this.button_regisztracio.TabIndex = 4;
            this.button_regisztracio.Text = "Regisztráció";
            this.button_regisztracio.UseVisualStyleBackColor = true;
            // 
            // FormRegisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 184);
            this.Controls.Add(this.button_regisztracio);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.textBox_felhasznalonev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegisztracio";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_felhasznalonev;
        private System.Windows.Forms.TextBox textBox_jelszo;
        private System.Windows.Forms.Button button_regisztracio;
    }
}