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
            nilai = Convert.ToDouble(x);
            File.Delete("Nilai.txt");
            label3.Text = nilai.ToString();
        }

        private void BINGO_IsiNama_Load(object sender, EventArgs e)
        {

        }

        private void BINGO_IsiNama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string nama;
            nama = textBox1.Text;
            if (textBox1.Text.Length==0)
            {
                valid = false;
            }
            else
            {
                if (nama[0] ==' ')
                {
                    int index = 0;
                    valid = false;
                    for (int i = 0; i < nama.Length; i++)
                    {
                        if(nama[i]!=' ')
                        {
                            valid = true;
                            index = i;
                            break;
                        }
                    }
                    string temp;
                    temp = nama;
                    for (int j = 0; j < index; j++)
                    {
                        temp.Remove(0, 1);
                    }
                    nama = temp;
                }
            }
            if (!valid) MessageBox.Show("Nama tidak boleh kosong !!!");
            else
            {
                //menu daftar score
            }
        }
    }
}
