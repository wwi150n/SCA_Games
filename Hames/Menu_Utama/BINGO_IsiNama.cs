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
                List<double> lnilai=new List<double>();
                List<string> lnama = new List<string>();
                lnilai.Add(nilai);
                lnama.Add(nama);
                if (!File.Exists("Nama.txt"))
                {
                    File.Create("Nama.txt").Close();
                }
                else
                {
                    string a;
                    string[] b;
                    string tnama;
                    double tnilai;
                    StreamReader sr = new StreamReader("Nama.txt");
                    do
                    {
                        a = sr.ReadLine();
                        b = a.Split(' ');
                        lnama.Add(b[0]);
                        lnilai.Add(Convert.ToDouble(b[1]));
                    } while (!sr.EndOfStream);
                    sr.Close();
                    File.Delete("Nama.txt");
                    for (int i = 0; i < lnama.Count-1; i++)
                    {
                        if (lnilai[i] <= lnilai[i + 1])
                        {
                            tnama = lnama[i];
                            tnilai = lnilai[i];
                            lnama[i] = lnama[i + 1];
                            lnilai[i] = lnilai[i + 1];
                            lnama[i + 1] = tnama;
                            lnilai[i+1] = tnilai;
                        }
                    }
                }
                File.Create("Nama.txt").Close() ;
                StreamWriter sw = new StreamWriter("Nama.txt");
                for (int i = 0; i < lnama.Count; i++)
                {
                    sw.WriteLine(lnama[i]+" "+lnilai[i]);
                }
                sw.Close();
                //menu daftar score
                BINGO_NilaiTertinggi frm = new BINGO_NilaiTertinggi();
                this.Hide();
                frm.Show();
            }
        }
    }
}
