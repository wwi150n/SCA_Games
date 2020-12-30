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
    public partial class BINGO_Main : Form
    {
        public BINGO_Main()
        {
            InitializeComponent();
        }
        public void main1(object sender,EventArgs e)
        {
            if (!stop)
            {
                int kx = 0, ky = 0;
                Button x = ((Button)sender);
                x.Enabled = false;
                x.BackColor = Color.Yellow;
                for (int i = 0; i < stg; i++)
                {
                    for (int j = 0; j < stg; j++)
                    {
                        if (Convert.ToInt32(x.Text) == player[i, j])
                        {
                            kx = i;
                            ky = j;
                        }
                    }
                }
                player[kx, ky] = 0;
                pplayer += mcek(kx, ky, player, 1);
                for (int i = 0; i < stg; i++)
                {
                    for (int j = 0; j < stg; j++)
                    {
                        if (Convert.ToInt32(x.Text) == com[i, j])
                        {
                            kx = i;
                            ky = j;
                        }
                    }
                }
                txt5[kx, ky].BackColor = Color.Yellow;
                com[kx, ky] = 0;
                pcom += mcek(kx, ky, com, 2);
                label4.Text = pplayer.ToString();
                label5.Text = pcom.ToString();
                if ((pplayer >= stg) | (pcom >= stg)) stop = true;
            }
            turn++;
            if (stop) selesai();
            else
            {
                //mesin komputer
            }
        }
        public Button[,] btn5 = new Button[5, 5];
        public Button[,] btn7 = new Button[7, 7];
        public Button[,] btn9 = new Button[9, 9];
        public string p1 = "", p2 = "";
        public int[,] player;
        public int[,] com;
        public int pplayer = 0;
        public int pcom = 0;
        public bool stop = false;
        public int angkacom;
        public int turn = 0;
        public TextBox[,] txt5 = new TextBox[5, 5];
        public TextBox[,] txt7 = new TextBox[7, 7];
        public TextBox[,] txt9 = new TextBox[9, 9];
        public int tingkat = 2;
        public int stg = 5;

        public void selesai()
        {
            int nilai;
            nilai = 17;
            if ((pplayer >= stg) & (pcom >= stg))
            {
                MessageBox.Show("Permainan imbang, silahkan coba lagi");

            }
            else if (pplayer >= stg)
            {
                MessageBox.Show(turn.ToString());
                //fitur isi nama
            }
            else if (pcom >= stg)
            {
                MessageBox.Show("Anda kalah, silahkan coba lagi");
            }
        }
        public int mcek(int x,int y, int[,] posisi, int pemain)
        {
            int hitung = 0;
            bool status = true;
            //cek horizontal
            status = true;
            for (int i = 0; i < stg; i++)
            {
                if (posisi[x,i]!=0)
                {
                    status = false;
                    break;
                }
            }
            if (status)
            {
                hitung += 1;
                if (pemain == 1)
                {
                    for (int i = 0; i < stg; i++)
                    {
                        btn5[x, i].BackColor = Color.Green;
                    }
                }
                else if(pemain == 2)
                {
                    for(int i = 0; i < stg; i++)
                    {
                        txt5[x, i].BackColor = Color.Green;
                    }
                }
            }
            //cek vertikal
            status = true;
            for(int i = 0; i < stg; i++)
            {
                if (posisi[i, y] != 0)
                {
                    status = false;
                    break;
                }
            }
            if (status)
            {
                hitung += 1;
                if (pemain == 1)
                {
                    for (int i = 0; i < stg; i++)
                    {
                        btn5[i, y].BackColor = Color.Green;
                    }
                }
                else if (pemain == 2)
                {
                    for (int i = 0; i < stg; i++)
                    {
                        txt5[i, y].BackColor = Color.Green;
                    }
                }
            }
            //cek diagonal (kiri ke kanan)(x=y)
            if (x==y)
            {
                status = true;
                for (int i = 0; i < stg; i++)
                {
                    if (posisi[i, i] != 0) status = false;
                }
                if (status)
                {
                    for (int i = 0; i < stg; i++)
                    {
                        if (pemain==1)
                        {
                            btn5[i, i].BackColor = Color.Green;
                        }
                        else if (pemain == 2)
                        {
                            btn5[i, i].BackColor = Color.Green;
                        }
                    }
                    hitung += 1;
                }
            }
            //cek diagonal(kanan ke kiri)(x=stg-1-y)
            if (x==stg-1-y)
            {
                status = true;
                for (int i = 0; i < stg; i++)
                {
                    if (posisi[i, stg - 1 - i] != 0) status = false;
                }
                if (status)
                {
                    for (int i = 0; i < stg; i++)
                    {
                        if (pemain==1)
                        {
                            btn5[i, stg - 1 - i].BackColor = Color.Green;
                        }
                        else if (pemain == 2)
                        {
                            txt5[i, stg - 1 - i].BackColor = Color.Green;
                        }                      
                    }
                    hitung += 1;
                }
            }
            return hitung;
        }
        private void BINGO_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
