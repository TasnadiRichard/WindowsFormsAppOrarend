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
    public partial class FormModositas : Form
    {
        string modify = null;
        Ora KivalasztasModify = null;
        public FormModositas(string modify)
        {
            InitializeComponent();
            this.modify = modify;
        }
     

        private void FormModositas_Load(object sender, EventArgs e)
        {
            switch (modify)
            {
                case "beszúrás":
                    this.Text = "Új óra, sorszám, tantárgy hozzáadása";
                    orarendszerkesztes();
                    break;
                case "törlés":
                    this.Text = "óra, sorszám, tantárgy törlése";
                    orarendszerkesztes();
                    break;
                case "módosítás":
                    this.Text = "óra, sorszám, tantárgy módosítása";
                    orarendszerkesztes();
                    break;
                default:
                    break;
            }

        }

        private void orarendszerkesztes()
        {
            textBox_oraid.Text = KivalasztasModify.oraid.ToString();
            textBox_tantargy.Text = KivalasztasModify.tantargy.ToString();
            numericUpDown_sorszam.Value = KivalasztasModify.sorszam;
            comboBox_hetnapja.Text = KivalasztasModify.hetnapja.ToString();
        }
    }
}
