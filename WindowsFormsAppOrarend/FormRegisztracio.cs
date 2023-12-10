using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    public partial class FormRegisztracio : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public FormRegisztracio()
        {
            InitializeComponent();
        }

        private void button_regisztracio_Click(object sender, EventArgs e)
        {
            if (textBox_jelszo.Text == textBoxjelszo.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orarend.tanarok WHERE tanarnev='" + textBox_felhasznalonev.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Már létezik felhasználónév, próbálkozzon másikkal ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orarend.tanarok VALUES(@tanarnev,@jelszo)", cn);
                    cmd.Parameters.AddWithValue("tanarnev", textBoxnev.Text);
                    cmd.Parameters.AddWithValue("jelszo", textBoxjelszo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hozzon létre egy profilt. Kérem, lépjen be.", "Kész", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
