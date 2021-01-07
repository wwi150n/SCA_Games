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
    public partial class BINGO_NilaiTertinggi : Form
    {
        public BINGO_NilaiTertinggi()
        {
            InitializeComponent();
        }

        private void BINGO_NilaiTertinggi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BINGO_Menu frm = new BINGO_Menu();
            this.Hide();
            frm.Show();
        }

        private void BINGO_NilaiTertinggi_Load(object sender, EventArgs e)
        {
            string n="";
            int hitung = 1;
            string a;
            string[] b;
            if (File.Exists("Nama.txt"))
            {
                StreamReader sr = new StreamReader("Nama.txt");
                do
                {
                    a = sr.ReadLine();
                    b = a.Split();
                    n += hitung.ToString()+"\t"+b[0]+"\t"+b[1];
                    hitung++;
                } while (!sr.EndOfStream);
            }

        }
    }
}
