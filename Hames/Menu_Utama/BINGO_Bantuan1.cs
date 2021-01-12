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
    public partial class BINGO_Bantuan1 : Form
    {
        public BINGO_Bantuan1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BINGO_Menu frm = new BINGO_Menu();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BINGO_Bantuan2 frm = new BINGO_Bantuan2();
            this.Hide();
            frm.Show();
        }
    }
}
