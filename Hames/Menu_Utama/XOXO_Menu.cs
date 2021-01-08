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
    public partial class XOXO_Menu : Form
    {
        public XOXO_Menu ()
        {
            InitializeComponent();
            foreach (Control item in Controls)
            {
               
                
            }
        }

            

        bool turn = true; // true = x trun, false O turn
        int turn_count = 0;

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("XOXO By Sylvia Dewi Chaiyanti", "XOXO about");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            XOXO_utama home = new XOXO_utama();
            this.Hide();
            home.Show();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("XOXO By Sylvia Dewi Chaiyanti", "XOXO about");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XOXO_utama home = new XOXO_utama();
            this.Hide();
            home.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

