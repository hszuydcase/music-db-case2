using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SQLService sqlService = new SQLService();

            sqlService.Insert(" INSERT INTO gebruiker(username, password, user_voornaam, user_achternaam, email, admin_level)VALUES(N'hallo', N'hallo', N'Josh', N'Welstar', N'nwelstart@lol.com', 1) ");
        }
    }
}
