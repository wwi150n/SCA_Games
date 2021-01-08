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
    public partial class XOXO_utama : Form
    {
        public XOXO_utama()
        {
            InitializeComponent();
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Click += new EventHandler(main1);
                }
            }

        }

        private bool xWasClicked = true;
        private bool OWasClicked = false;
        public int giliran = 1;
        public int nilai = 0;
        public int scorePemain1 = 0;
        public int scorePemain2 = 0;
        public int[,] var = new int[12, 12];


        public void main1(object sender, EventArgs e)
        {
            string temp;
            string textbox1, textbox2;
            textbox1 = label2.Text;
            textbox2 = label3.Text;
            Button x = ((Button)sender);
            x.Enabled = false;
            x.BackColor = Color.Yellow;
            temp = x.Name.ToString();
            int baris, kolom;
            int angka;
            int gantian;
            gantian = giliran % 2;
            angka = Convert.ToInt32(temp.Remove(0, 1));
            baris = (angka - 1) / 12;
            kolom = (angka - 1) % 12;
            if (baris != 12)
            {
                if (xWasClicked)
                {
                    var[baris, kolom] = 1;
                    x.Text = "X";
                    b01.Enabled = true;
                    b02.Enabled = true;
                    b01.BackColor = Color.White;
                    b02.BackColor = Color.Pink;
                }
                else
                {
                    var[baris, kolom] = 0;
                    x.Text = "O";
                    //cek horizontal
                    if ((kolom != 0) && (kolom != 11))
                    {
                        if (((var[baris, kolom - 1]) == 1) && ((var[baris, kolom + 1]) == 1))
                        {
                            nilai += 1;
                            if (gantian == 1)
                            {
                                scorePemain1 += 1;
                                scorep1.Text = Convert.ToString(scorePemain1);
                                //ubah warna "O"

                            }
                            else if (gantian == 0)
                            {
                                scorePemain2 += 1;
                                scorep2.Text = Convert.ToString(scorePemain2);
                                x.ForeColor = Color.Indigo;
                            }
                        }
                    }
                    b01.Enabled = true;
                    b02.Enabled = true;
                    b01.BackColor = Color.White;
                    b02.BackColor = Color.Pink;
                }
                giliran += 1;
            }
            else
            {
                if (xWasClicked)
                {
                    b01.BackColor = Color.White;
                    b02.BackColor = Color.Pink;
                }
                else if (OWasClicked)
                {
                    b01.BackColor = Color.Pink;
                    b02.BackColor = Color.White;
                }
            }
            if (gantian != 1)
            {
                textbox2 = label3.Text;
                label3.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Black;
            }
            else
            {
                textbox1 = label2.Text;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Black;
            }

        }

        private void b01_Click(object sender, EventArgs e)
        {
            xWasClicked = true;
            OWasClicked = false;
        }

        private void b02_Click(object sender, EventArgs e)
        {
            xWasClicked = false;
            OWasClicked = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("XOXO By Sylvia Dewi Chaiyanti", "XOXO about");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XOXO_utama home = new XOXO_utama();
            this.Hide();
            home.Show();
        }

        private void XOXO_utama_Load(object sender, EventArgs e)
        {



            {
            }
        }
    }
}

    



    

