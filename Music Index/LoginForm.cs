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
            // QUERY UITVOEREN DOET DIE NIET GOED ZOWEL DELETE ALS INSERT NIET
            
            SQLService sqlService = new SQLService();

            string commando2 = "UPDATE gebruiker SET username = 'lul'  WHERE user_id = 1 ";
            sqlService.Update(commando2);
        }
    }
}
