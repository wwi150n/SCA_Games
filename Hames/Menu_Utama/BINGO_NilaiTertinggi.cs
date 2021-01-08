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

        public struct Data
        {
            public float n;
            public string nama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BINGO_Menu frm = new BINGO_Menu();
            this.Hide();
            frm.Show();
        }

        private void BINGO_NilaiTertinggi_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Data temp = new Data();
            string[] y1;
            List<Data> daftar = new List<Data>();
            temp.n = 59f;
            temp.nama = "Agus";
            daftar.Add(temp);
            temp.n = 58f;
            temp.nama = "Budi";
            daftar.Add(temp);
            temp.n = 57f;
            temp.nama = "Chitra";
            daftar.Add(temp);
            temp.n = 56f;
            temp.nama = "Domino";
            daftar.Add(temp);
            temp.n = 55f;
            temp.nama = "Erlangga";
            daftar.Add(temp);
            temp.n = 54f;
            temp.nama = "Fajar";
            daftar.Add(temp);
            temp.n = 53f;
            temp.nama = "Gandhi";
            daftar.Add(temp);
            temp.n = 52f;
            temp.nama = "Hansono";
            daftar.Add(temp);
            temp.n = 51f;
            temp.nama = "Ijun";
            daftar.Add(temp);
            temp.n = 50f;
            temp.nama = "Jaguar";
            daftar.Add(temp);
            if (File.Exists("Nama.txt"))
            {
                y1 = File.ReadAllLines("Nama.txt");
                for (int i = 0; i < y1.Length; i++)
                {
                    string[] temp2 = y1[i].Split();
                    temp.nama = temp2[0];
                    temp.n = Convert.ToSingle(temp2[1]);
                    daftar.Add(temp);
                }
            }

            for (int i = 0; i < daftar.Count - 1; i++)
            {
                for (int j = i + 1; j < daftar.Count; j++)
                {
                    if (daftar[i].n < daftar[j].n)
                    {
                        temp = daftar[i];
                        daftar[i] = daftar[j];
                        daftar[j] = temp;
                    }
                }
            }
            File.Delete("Nama.txt");
            File.Create("Nama.txt").Close();
            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText("Nama.txt", daftar[i].nama + " " + daftar[i].n + "\n");
            }
            string[] y = File.ReadAllLines("Nama.txt");
            for (int i = 0; i < y.Length; i++)
            {
                string a;
                string[] b;
                a = y[i].ToString();
                b = a.Split();
                Data x = new Data();
                x.nama = b[0].ToString();
                x.n = Convert.ToSingle(b[1]);
                string hasil = $"{(i + 1).ToString().PadLeft(2,'0')}.\t{x.nama.PadRight(20)}\t{x.n}";
                listBox1.Items.Add(hasil);
            }

        }
    }
}
