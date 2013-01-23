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
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.Insert("INSERT INTO Categorie (Catergorie_naam) VALUES('" + textBox1.Text +"')");
        }
    }
}
