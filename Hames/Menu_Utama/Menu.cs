using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Utama
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BINGO_Menu frm1 = new BINGO_Menu();
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XOXO_Menu frm1 = new XOXO_Menu();
            this.Hide();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SOS_Menu frm1 = new SOS_Menu();
            this.Hide();
            frm1.Show();
        }
    }
}
