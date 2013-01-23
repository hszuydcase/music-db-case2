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
            try
            {
                SQLService sqlService = new SQLService();
                bool bestaat = sqlService.Bestaat("SELECT * FROM gebruiker WHERE username = '" + inputUsername.Text + "' AND password = '" + inputPassword.Text + "' ");

                if (bestaat == false)
                {
                    MessageBox.Show("Bestaat niet");
                }
                else
                {
                    MessageBox.Show("Bestaat");
                }
            }
            catch (Exception)
            {
                
                throw;
            }


        }

        private void btRegistreer_Click(object sender, EventArgs e)
        {
            try
            {
                SQLService sqlService = new SQLService();
                sqlService.Insert("INSERT INTO gebruiker (username,password,user_voornaam,user_achternaam,email,admin_level) VALUES ('Josh', 'Josh','Josh','Josh','Josh',1) ");
            }
            catch (Exception obj)
            {

                MessageBox.Show(obj.Message);
            }
        }
    }
}
