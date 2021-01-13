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
    public partial class XOXO_Help : Form
    {
        public XOXO_Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XOXO_Menu frm = new XOXO_Menu();
            this.Hide();
            frm.Show();
        }

        private void XOXO_Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    
  }
}
