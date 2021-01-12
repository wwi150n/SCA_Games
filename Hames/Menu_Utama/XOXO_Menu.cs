﻿using System;
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
            if ((textBox1.Text == "")|| (textBox2.Text == ""))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Nama Pemain 1 tidak boleh kosong !!!","Notifikasi");
                    textBox1.BackColor = Color.MistyRose;
                }
                else
                {
                    textBox1.BackColor = Color.GreenYellow;
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Nama Pemain 2 tidak boleh kosong !!!", "Notifikasi");
                        textBox2.BackColor = Color.MistyRose;
                    }
                    else
                    {
                        textBox2.BackColor = Color.GreenYellow;
                    }
                }
            }
            else
            {
                if (!File.Exists("Namax.txt"))
                {
                    File.Create("Namax.txt").Close();
                }
                StreamWriter sw = new StreamWriter("Namax.txt");
                sw.WriteLine(textBox1.Text + " " + textBox2.Text);
                sw.Close();

                if (!File.Exists("Peranx.txt"))
                {
                    File.Create("Peranx.txt").Close();
                }
                StreamWriter sw2 = new StreamWriter("Peranx.txt");
                sw2.WriteLine(label3.Text + " " + label4.Text);
                sw2.Close();
                XOXO_utama home = new XOXO_utama();
                this.Hide();
                home.Show();
            }
            
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "X")
            {
                label3.Text = "O";
                label4.Text = "X";
            }
            else
            {
                label3.Text = "X";
                label4.Text = "O";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            XOXO_Main str = new XOXO_Main();
            this.Hide();
            str.Show();

        }

        private void XOXO_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XOXO_Help frm = new XOXO_Help();
            this.Hide();
            frm.Show();
        }
    }
    }

