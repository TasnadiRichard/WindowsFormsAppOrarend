using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsAppOrarend;

namespace WindowsFormsAppLogin
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection();
            command = connection.CreateCommand();
            try
            {
                nyit();

                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public List<Ora> getModify()
        {
            nyit();
            List<Ora> modositas = new List<Ora>();
            command.CommandText = "SELECT `oraid`,`tantargy`,`sorszam`,`hetnapja` FROM `orak` WHERE 1 ORDER BY tanarnev";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    modositas.Add(new Ora(dr.GetInt16("oraid"), dr.GetString("tantargy"), dr.GetInt16("sorszam"), dr.GetString("hetnapja")));
                }
            }
            zar();
            return modositas;  

        }
        public int ValidUser(string username, string password)
        {
            int userid = -1;
            command.CommandText = "SELECT tanarok.jelszo, tanarok.tanarid FROM tanarok WHERE tanarok.tanarnev=@tanarnev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_felhasznalonev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();   
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                Program.UserID = reader.GetInt16("tanarnev");
            }
            zar();
            return userid;
        }

    
    }
}
