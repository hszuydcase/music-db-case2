using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Music_Index
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // QUERY UITVOEREN DOET DIE NIET GOED ZOWEL DELETE ALS INSERT NIET
            string connectionStringg = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=|DataDirectory|\MusicIndexDataSet.sdf";
            OleDbConnection connection = new OleDbConnection(connectionStringg);
            OleDbCommand deleteCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            try
            {
                connection.Open();

                string command = "INSERT INTO Band (band_naam) VALUES ('nikstedoen')";

                deleteCommand.Connection = connection;
                deleteCommand.CommandText = command;
                adapter.DeleteCommand = deleteCommand;

                int rows = adapter.DeleteCommand.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("NIET GELUKT");
                }
                else
                {
                    MessageBox.Show("VERWIJDERD");
                }
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }
            finally
            {
                connection.Close();
            }


        }
    }
}
