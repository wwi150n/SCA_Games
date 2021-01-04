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
    public partial class BINGO_Angka : Form
    {
        public BINGO_Angka()
        {
            InitializeComponent();
        }

        public void xlabel(int ukur, TextBox[] txt)
        {
            //inisialisasi label dan textbox
            for(int i = 0; i < ukur * ukur; i++)
            {
                txt[i].Visible = true;
            }
        }
        public TextBox[] txt5 = new TextBox[25];
        public TextBox[] txt7 = new TextBox[49];
        public TextBox[] txt9 = new TextBox[81];
        public int[] tmp;
        public bool status;
        public string a;
        public string[] b;
        private void BINGO_Angka_Load(object sender, EventArgs e)
        {
            txt9[0] = textBox1;
            txt9[1] = textBox2;
            txt9[2] = textBox3;
            txt9[3] = textBox4;
            txt9[4] = textBox5;
            txt9[5] = textBox6;
            txt9[6] = textBox7;
            txt9[7] = textBox8;
            txt9[8] = textBox9;
            txt9[9] = textBox10;
            txt7[0] = txt9[10] = textBox11;
            txt7[1] = txt9[11] = textBox12;
            txt7[2] = txt9[12] = textBox13;
            txt7[3] = txt9[13] = textBox14;
            txt7[4] = txt9[14] = textBox15;
            txt7[5] = txt9[15] = textBox16;
            txt7[6] = txt9[16] = textBox17;
            txt9[17] = textBox18;
            txt9[18] = textBox19;
            txt7[7] = txt9[19] = textBox20;
            txt5[0] = txt7[8] = txt9[20] = textBox21;
            txt5[1] = txt7[9] = txt9[21] = textBox22;
            txt5[2] = txt7[10] = txt9[22] = textBox23;
            txt5[3] = txt7[11] = txt9[23] = textBox24;
            txt5[4] = txt7[12] = txt9[24] = textBox25;
            txt7[13] = txt9[25] = textBox26;
            txt9[26] = textBox27;
            txt9[27] = textBox28;
            txt7[14] = txt9[28] = textBox29;
            txt5[5] = txt7[15] = txt9[29] = textBox30;
            txt5[6] = txt7[16] = txt9[30] = textBox31;
            txt5[7] = txt7[17] = txt9[31] = textBox32;
            txt5[8] = txt7[18] = txt9[32] = textBox33;
            txt5[9] = txt7[19] = txt9[33] = textBox34;
            txt7[20] = txt9[34] = textBox35;
            txt9[35] = textBox36;
            txt9[36] = textBox37;
            txt7[21] = txt9[37] = textBox38;
            txt5[10] = txt7[22] = txt9[38] = textBox39;
            txt5[11] = txt7[23] = txt9[39] = textBox40;
            txt5[12] = txt7[24] = txt9[40] = textBox41;
            txt5[13] = txt7[25] = txt9[41] = textBox42;
            txt5[14] = txt7[26] = txt9[42] = textBox43;
            txt7[27] = txt9[43] = textBox44;
            txt9[44] = textBox45;
            txt9[45] = textBox46;
            txt7[28] = txt9[46] = textBox47;
            txt5[15] = txt7[29] = txt9[47] = textBox48;
            txt5[16] = txt7[30] = txt9[48] = textBox49;
            txt5[17] = txt7[31] = txt9[49] = textBox50;
            txt5[18] = txt7[32] = txt9[50] = textBox51;
            txt5[19] = txt7[33] = txt9[51] = textBox52;
            txt7[34] = txt9[52] = textBox53;
            txt9[53] = textBox54;
            txt9[54] = textBox55;
            txt7[35] = txt9[55] = textBox56;
            txt5[20] = txt7[36] = txt9[56] = textBox57;
            txt5[21] = txt7[37] = txt9[57] = textBox58;
            txt5[22] = txt7[38] = txt9[58] = textBox59;
            txt5[23] = txt7[39] = txt9[59] = textBox60;
            txt5[24] = txt7[40] = txt9[60] = textBox61;
            txt7[41] = txt9[61] = textBox62;
            txt9[62] = textBox63;
            txt9[63] = textBox64;
            txt7[42] = txt9[64] = textBox65;
            txt7[43] = txt9[65] = textBox66;
            txt7[44] = txt9[66] = textBox67;
            txt7[45] = txt9[67] = textBox68;
            txt7[46] = txt9[68] = textBox69;
            txt7[47] = txt9[69] = textBox70;
            txt7[48] = txt9[70] = textBox71;
            txt9[71] = textBox72;
            txt9[72] = textBox73;
            txt9[73] = textBox74;
            txt9[74] = textBox75;
            txt9[75] = textBox76;
            txt9[76] = textBox77;
            txt9[77] = textBox78;
            txt9[78] = textBox79;
            txt9[79] = textBox80;
            txt9[80] = textBox81;
            for (int i = 0; i < 81; i++)
            {
                txt9[i].Visible = false;
            }
            xlabel(5, txt5);
        }

        public void xpengecekan(int ukur, TextBox[] txt)
        {
            //pengecekan nilai
            status = true;
            tmp = new int[ukur * ukur];
            for (int i = 0; i < ukur; i++)
            {
                for (int j = 0; j < ukur; j++)
                {
                    bool stt = true;
                    a = txt[ukur * i + j].Text;
                    if (a.Length == 0)
                    {
                        //pengecekan null
                        stt = false;
                        status = false;
                        txt[ukur * i + j].BackColor = Color.Red;
                    }
                    for (int k = 0; k < a.Length; k++)
                    {
                        //pengecekan angka
                        if (!Char.IsDigit(a[k]))
                        {
                            stt = false;
                            status = false;
                            txt[ukur * i + j].BackColor = Color.Red;
                        }
                    }
                    if (stt)
                    {
                        if ((Convert.ToInt32(a) <= 0) || (Convert.ToInt32(a) > (ukur * ukur)))
                        {
                            stt = false;
                            status = false;
                            txt[ukur * i + j].BackColor = Color.Red;
                        }
                    }
                    if (stt)
                    {
                        tmp[ukur * i + j] = Convert.ToInt32(txt[ukur * i + j].Text);
                        txt[ukur * i + j].BackColor = Color.LightGreen;
                    }
                }
            }
            for (int i = 0; i < ukur*ukur; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //pengecekan nilai yang sama
                    if (tmp[i] == tmp[j])
                    {
                        status = false;
                        txt[i].BackColor = Color.Red;
                        txt[j].BackColor = Color.Red;
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int stg = 5;

            //cek setting
            xpengecekan(5, txt5);

            if (status)
            {
                //isi angka(25-81)
                isiangka(5, txt5);

                BINGO_Main frm1 = new BINGO_Main();
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Data tidak valid!!!", "Informasi");
            }
        }

        public void isiangka(int ukur,TextBox[] txt)
        {
            if (!File.Exists("angka.txt")) File.Create("angka.txt").Close();
            StreamWriter sw = new StreamWriter("angka.txt");
            for (int i = 0; i < ukur * ukur; i++) sw.Write("{0} ", txt[i].Text.ToString());
            sw.Close();
        }
        private void BINGO_Angka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
