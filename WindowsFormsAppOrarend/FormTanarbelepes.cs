using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    public partial class FormTanarbelepes : Form
    {
        public FormTanarbelepes()
        {
            InitializeComponent();
        }
    }

    private void button_regisztracio_Click(object sender, EventArgs e)
    {
        FormRegisztracio regisztracio = new FormRegisztracio();
            if (Program.db.validUser(textBox_felhasznalonev.Text, textBoxjelszo.Text) >= 0)
            {
                Program.formRegisztracio.Show();
            }
            register.Show();
    }

    private void button_bejelentkezes_Click(object sender, EventArgs e)
        {
            if (Program.db.validUser(textBox_felhasznalonev.Text, textBoxjelszo.Text) >= 0)
            {
                Program.formOrak.Show();
            }
        }
}
