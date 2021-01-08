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
    public partial class BINGO_Menu : Form
    {
        public BINGO_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BINGO_Angka frm1 = new BINGO_Angka();
            this.Hide();
            frm1.Show();
        }

        private void BINGO_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BINGO_NilaiTertinggi frm = new BINGO_NilaiTertinggi();
            this.Hide();
            frm.Show();
        }
    }
}
