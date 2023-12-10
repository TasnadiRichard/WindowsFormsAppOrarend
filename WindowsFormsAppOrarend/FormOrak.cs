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
    public partial class FormOrak : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public FormOrak()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_uj_Click(object sender, EventArgs e)
        {
            FormModositas formUj = new FormModositas("beszúrás");
            formkUj.ShowDialog(); 
        }

        private void ToolStripMenuItem_modositas_Click(object sender, EventArgs e)
        {
            FormModositas formUpdate = new FormModositas("módosítás");
            formUpdate.ShowDialog();
        }

        private void ToolStripMenuItem_torles_Click(object sender, EventArgs e)
        {
            FormModositas formDelete = new FormModositas("törlés");
            formDelete.ShowDialog();
        }

        private void listBoxTanarok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_tanarok.SelectedIndex < 0)
            {
                return;
            }
            Ora kivalasztottTanarok = (Ora)listBox_tanarok.SelectedItem;
            textBox_oraid.Text = kivalasztottTanarok.oraid.ToString();
            comboBox_tantargy.Text = kivalasztottTanarok.tantargy; 
            numericUpDown_sorszam.Value = kivalasztottTanarok.sorszam; 
            numericUpDown_sorszam.Maximum = kivalasztottTanarok.sorszam; 
            numericUpDown_sorszam.Value = -1;
            comboBox_nap.Text = kivalasztottTanarok.hetnapja; 
            textBox_oraid_TextChanged();
            numericUpDown_sorszam_ValueChanged();
            comboBox_tantargy_SelectedIndexChanged();
            comboBox_nap_SelectedIndexChanged();

        }

        private void button_megerosites_Click(object sender, EventArgs e)
        {
            string text = $"Szeretné-e a kíválasztani azt a tanárt akihez az adott napon szeretne menni: ${comboBox_tantargy}, ${numericUpDown_sorszam}, ${comboBox_nap}?";
        }

        private void textBox_oraid_TextChanged(object sender, EventArgs e)
        {
           
            if (textBox_oraid.Text == textBox_oraid.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.oraid WHERE oraid='" + textBox_oraid.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();                    
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.oraid VALUES(@oraid)", cn);
                    cmd.Parameters.AddWithValue("oraid", textBox_oraid.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBox_tanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBox_tanarok.SelectedItem;
                textBox_oraid.Text = kivalasztottTanarok.oraid.ToString();
                MessageBox.Show("Kérem, írja be a jelszó ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void numericUpDown_sorszam_ValueChanged(object sender, EventArgs e)
        {
           
            if (comboBox_tantargy.Text == comboBox_tantargy.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.tantargy WHERE tantargy='" + comboBox_tantargy.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.tantargy VALUES(@tantargy)", cn);
                    cmd.Parameters.AddWithValue("tantargyak", comboBox_tantargy.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBox_tanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBox_tanarok.SelectedItem;
                comboBox_tantargy.Text = kivalasztottTanarok.tantargy; 
        }

        private void comboBox_tantargy_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (numericUpDown_sorszam.Text == numericUpDown_sorszam.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.sorszam WHERE sorszam='" + numericUpDown_sorszam.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.sorszam VALUES(@sorszam)", cn);
                    cmd.Parameters.AddWithValue("sorszam", numericUpDown_sorszam.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBox_tanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBox_tanarok.SelectedItem;
                numericUpDown_sorszam.Value = kivalasztottTanarok.sorszam;
            }
        }

        private void comboBox_nap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hozzá adja a textboxTanarok-ba és így megjelenik az amire választott
            if (comboBox_nap.Text == comboBox_nap.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.hetnapja WHERE hetnapja='" + comboBox_nap.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.hetnapja VALUES(@hetnapja)", cn);
                    cmd.Parameters.AddWithValue("hetnapja", comboBox_nap.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBox_tanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBox_tanarok.SelectedItem;
                comboBox_nap.Text = kivalasztottTanarok.hetnapja;
            }
        }
    }
}