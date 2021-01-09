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
    public partial class BINGO_Pengaturan : Form
    {
        public BINGO_Pengaturan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tingkat;
            if (radioButton1.Checked) tingkat = "Mudah";
            else if (radioButton2.Checked) tingkat = "Sedang";
            else tingkat = "Sulit";
            if (!File.Exists("Pengaturan.txt"))
            {
                File.Create("Pengaturan.txt").Close();
            }
            StreamWriter sw = new StreamWriter("Pengaturan.txt");
            sw.WriteLine(numericUpDown1.Value + " " + comboBox1.Text + " " + comboBox2.Text + " " + tingkat);
            sw.Close();
            BINGO_Menu frm1 = new BINGO_Menu();
            this.Hide();
            frm1.Show();
        }

        private void BINGO_Pengaturan_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pengaturan.txt"))
            {
                numericUpDown1.Value = 5;
                comboBox1.Text = "Biru";
                comboBox2.Text = "Putih";
                radioButton2.Checked = true;
                string a;
                string[] b;
                StreamReader sr = new StreamReader("Pengaturan.txt");
                a = sr.ReadLine();
                b = a.Split();
                if (b[0] == "7")
                {
                    numericUpDown1.Value = 7;
                }
                else if (b[0] == "9")
                {
                    numericUpDown1.Value = 9;
                }
                if (b.Length >= 4)
                {
                    if (b[3] == "Mudah") radioButton1.Checked = true;
                    else if (b[3] == "Sulit") radioButton3.Checked = true;
                }
                else if (b.Length >= 2)
                {
                    if (b[1] == "Jingga") comboBox1.Text = "Jingga";
                    else if (b[1] == "Putih") comboBox1.Text = "Putih";
                    if (b[2] == "Biru") comboBox2.Text = "Biru";
                    else if (b[2] == "Jingga") comboBox2.Text = "Jingga";
                    if (comboBox1.Text == comboBox2.Text)
                    {
                        comboBox1.Text = "Biru";
                        comboBox2.Text = "Jingga";
                    }
                }
                sr.Close();
            }
        }
    }
}
