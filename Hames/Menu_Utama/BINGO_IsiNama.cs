using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Menu_Utama
{
    public partial class BINGO_IsiNama : Form
    {
        public double nilai;
        public BINGO_IsiNama()
        {
            InitializeComponent();
            string x;
            x = File.ReadAllText("Nilai.txt");

        }

        private void BINGO_IsiNama_Load(object sender, EventArgs e)
        {

        }

        private void BINGO_IsiNama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
