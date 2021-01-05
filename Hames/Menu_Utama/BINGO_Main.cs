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
    public partial class BINGO_Main : Form
    {
        public BINGO_Main()
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
                
                //taruh warna(tergantung setting)
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
                main2(stg);
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
                //ke daftar score
            }
            else if (pplayer >= stg)
            {
                MessageBox.Show(turn.ToString());
                //fitur isi nama
            }
            else if (pcom >= stg)
            {
                MessageBox.Show("Anda kalah, silahkan coba lagi");
                //ke daftar score
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
                        //perubahan warna
                        btn5[x, i].BackColor = Color.Green;
                    }
                }
                else if(pemain == 2)
                {
                    for(int i = 0; i < stg; i++)
                    {
                        //perubahan warna
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
                        //perubahan warna
                        btn5[i, y].BackColor = Color.Green;
                    }
                }
                else if (pemain == 2)
                {
                    for (int i = 0; i < stg; i++)
                    {
                        //perubahan warna
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
                            //perubahan warna
                            btn5[i, i].BackColor = Color.Green;
                        }
                        else if (pemain == 2)
                        {
                            //perubahan warna
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
                            //perubahan warna
                            btn5[i, stg - 1 - i].BackColor = Color.Green;
                        }
                        else if (pemain == 2)
                        {
                            //perubahan warna
                            txt5[i, stg - 1 - i].BackColor = Color.Green;
                        }                      
                    }
                    hitung += 1;
                }
            }
            return hitung;
        }

        private void BINGO_Main_Load(object sender, EventArgs e)
        {
            btn9[0, 0] = button1;
            btn9[0, 1] = button2;
            btn9[0, 2] = button3;
            btn9[0, 3] = button4;
            btn9[0, 4] = button5;
            btn9[0, 5] = button6;
            btn9[0, 6] = button7;
            btn9[0, 7] = button8;
            btn9[0, 8] = button9;
            btn9[1, 0] = button10;
            btn7[0, 0] = btn9[1, 1] = button11;
            btn7[0, 1] = btn9[1, 2] = button12;
            btn7[0, 2] = btn9[1, 3] = button13;
            btn7[0, 3] = btn9[1, 4] = button14;
            btn7[0, 4] = btn9[1, 5] = button15;
            btn7[0, 5] = btn9[1, 6] = button16;
            btn7[0, 6] = btn9[1, 7] = button17;
            btn9[1, 8] = button18;
            btn9[2, 0] = button19;
            btn7[1, 0] = btn9[2, 1] = button20;
            btn5[0, 0] = btn7[1, 1] = btn9[2, 2] = button21;
            btn5[0, 1] = btn7[1, 2] = btn9[2, 3] = button22;
            btn5[0, 2] = btn7[1, 3] = btn9[2, 4] = button23;
            btn5[0, 3] = btn7[1, 4] = btn9[2, 5] = button24;
            btn5[0, 4] = btn7[1, 5] = btn9[2, 6] = button25;
            btn7[1, 6] = btn9[2, 7] = button26;
            btn9[2, 8] = button27;
            btn9[3, 0] = button28;
            btn7[2, 0] = btn9[3, 1] = button29;
            btn5[1, 0] = btn7[2, 1] = btn9[3, 2] = button30;
            btn5[1, 1] = btn7[2, 2] = btn9[3, 3] = button31;
            btn5[1, 2] = btn7[2, 3] = btn9[3, 4] = button32;
            btn5[1, 3] = btn7[2, 4] = btn9[3, 5] = button33;
            btn5[1, 4] = btn7[2, 5] = btn9[3, 6] = button34;
            btn7[2, 6] = btn9[3, 7] = button35;
            btn9[3, 8] = button36;
            btn9[4, 0] = button37;
            btn7[3, 0] = btn9[4, 1] = button38;
            btn5[2, 0] = btn7[3, 1] = btn9[4, 2] = button39;
            btn5[2, 1] = btn7[3, 2] = btn9[4, 3] = button40;
            btn5[2, 2] = btn7[3, 3] = btn9[4, 4] = button41;
            btn5[2, 3] = btn7[3, 4] = btn9[4, 5] = button42;
            btn5[2, 4] = btn7[3, 5] = btn9[4, 6] = button43;
            btn7[3, 6] = btn9[4, 7] = button44;
            btn9[4, 8] = button45;
            btn9[5, 0] = button46;
            btn7[4, 0] = btn9[5, 1] = button47;
            btn5[3, 0] = btn7[4, 1] = btn9[5, 2] = button48;
            btn5[3, 1] = btn7[4, 2] = btn9[5, 3] = button49;
            btn5[3, 2] = btn7[4, 3] = btn9[5, 4] = button50;
            btn5[3, 3] = btn7[4, 4] = btn9[5, 5] = button51;
            btn5[3, 4] = btn7[4, 5] = btn9[5, 6] = button52;
            btn7[4, 6] = btn9[5, 7] = button53;
            btn9[5, 8] = button54;
            btn9[6, 0] = button55;
            btn7[5, 0] = btn9[6, 1] = button56;
            btn5[4, 0] = btn7[5, 1] = btn9[6, 2] = button57;
            btn5[4, 1] = btn7[5, 2] = btn9[6, 3] = button58;
            btn5[4, 2] = btn7[5, 3] = btn9[6, 4] = button59;
            btn5[4, 3] = btn7[5, 4] = btn9[6, 5] = button60;
            btn5[4, 4] = btn7[5, 5] = btn9[6, 6] = button61;
            btn7[5, 6] = btn9[6, 7] = button62;
            btn9[6, 8] = button63;
            btn9[7, 0] = button64;
            btn7[6, 0] = btn9[7, 1] = button65;
            btn7[6, 1] = btn9[7, 2] = button66;
            btn7[6, 2] = btn9[7, 3] = button67;
            btn7[6, 3] = btn9[7, 4] = button68;
            btn7[6, 4] = btn9[7, 5] = button69;
            btn7[6, 5] = btn9[7, 6] = button70;
            btn7[6, 6] = btn9[7, 7] = button71;
            btn9[7, 8] = button72;
            btn9[8, 0] = button73;
            btn9[8, 1] = button74;
            btn9[8, 2] = button75;
            btn9[8, 3] = button76;
            btn9[8, 4] = button77;
            btn9[8, 5] = button78;
            btn9[8, 6] = button79;
            btn9[8, 7] = button80;
            btn9[8, 8] = button81;

            txt9[0, 0] = textBox1;
            txt9[0, 1] = textBox2;
            txt9[0, 2] = textBox3;
            txt9[0, 3] = textBox4;
            txt9[0, 4] = textBox5;
            txt9[0, 5] = textBox6;
            txt9[0, 6] = textBox7;
            txt9[0, 7] = textBox8;
            txt9[0, 8] = textBox9;
            txt9[1, 0] = textBox10;
            txt7[0, 0] = txt9[1, 1] = textBox11;
            txt7[0, 1] = txt9[1, 2] = textBox12;
            txt7[0, 2] = txt9[1, 3] = textBox13;
            txt7[0, 3] = txt9[1, 4] = textBox14;
            txt7[0, 4] = txt9[1, 5] = textBox15;
            txt7[0, 5] = txt9[1, 6] = textBox16;
            txt7[0, 6] = txt9[1, 7] = textBox17;
            txt9[1, 8] = textBox18;
            txt9[2, 0] = textBox19;
            txt7[1, 0] = txt9[2, 1] = textBox20;
            txt5[0, 0] = txt7[1, 1] = txt9[2, 2] = textBox21;
            txt5[0, 1] = txt7[1, 2] = txt9[2, 3] = textBox22;
            txt5[0, 2] = txt7[1, 3] = txt9[2, 4] = textBox23;
            txt5[0, 3] = txt7[1, 4] = txt9[2, 5] = textBox24;
            txt5[0, 4] = txt7[1, 5] = txt9[2, 6] = textBox25;
            txt7[1, 6] = txt9[2, 7] = textBox26;
            txt9[2, 8] = textBox27;
            txt9[3, 0] = textBox28;
            txt7[2, 0] = txt9[3, 1] = textBox29;
            txt5[1, 0] = txt7[2, 1] = txt9[3, 2] = textBox30;
            txt5[1, 1] = txt7[2, 2] = txt9[3, 3] = textBox31;
            txt5[1, 2] = txt7[2, 3] = txt9[3, 4] = textBox32;
            txt5[1, 3] = txt7[2, 4] = txt9[3, 5] = textBox33;
            txt5[1, 4] = txt7[2, 5] = txt9[3, 6] = textBox34;
            txt7[2, 6] = txt9[3, 7] = textBox35;
            txt9[3, 8] = textBox36;
            txt9[4, 0] = textBox37;
            txt7[3, 0] = txt9[4, 1] = textBox38;
            txt5[2, 0] = txt7[3, 1] = txt9[4, 2] = textBox39;
            txt5[2, 1] = txt7[3, 2] = txt9[4, 3] = textBox40;
            txt5[2, 2] = txt7[3, 3] = txt9[4, 4] = textBox41;
            txt5[2, 3] = txt7[3, 4] = txt9[4, 5] = textBox42;
            txt5[2, 4] = txt7[3, 5] = txt9[4, 6] = textBox43;
            txt7[3, 6] = txt9[4, 7] = textBox44;
            txt9[4, 8] = textBox45;
            txt9[5, 0] = textBox46;
            txt7[4, 0] = txt9[5, 1] = textBox47;
            txt5[3, 0] = txt7[4, 1] = txt9[5, 2] = textBox48;
            txt5[3, 1] = txt7[4, 2] = txt9[5, 3] = textBox49;
            txt5[3, 2] = txt7[4, 3] = txt9[5, 4] = textBox50;
            txt5[3, 3] = txt7[4, 4] = txt9[5, 5] = textBox51;
            txt5[3, 4] = txt7[4, 5] = txt9[5, 6] = textBox52;
            txt7[4, 6] = txt9[5, 7] = textBox53;
            txt9[5, 8] = textBox54;
            txt9[6, 0] = textBox55;
            txt7[5, 0] = txt9[6, 1] = textBox56;
            txt5[4, 0] = txt7[5, 1] = txt9[6, 2] = textBox57;
            txt5[4, 1] = txt7[5, 2] = txt9[6, 3] = textBox58;
            txt5[4, 2] = txt7[5, 3] = txt9[6, 4] = textBox59;
            txt5[4, 3] = txt7[5, 4] = txt9[6, 5] = textBox60;
            txt5[4, 4] = txt7[5, 5] = txt9[6, 6] = textBox61;
            txt7[5, 6] = txt9[6, 7] = textBox62;
            txt9[6, 8] = textBox63;
            txt9[7, 0] = textBox64;
            txt7[6, 0] = txt9[7, 1] = textBox65;
            txt7[6, 1] = txt9[7, 2] = textBox66;
            txt7[6, 2] = txt9[7, 3] = textBox67;
            txt7[6, 3] = txt9[7, 4] = textBox68;
            txt7[6, 4] = txt9[7, 5] = textBox69;
            txt7[6, 5] = txt9[7, 6] = textBox70;
            txt7[6, 6] = txt9[7, 7] = textBox71;
            txt9[7, 8] = textBox72;
            txt9[8, 0] = textBox73;
            txt9[8, 1] = textBox74;
            txt9[8, 2] = textBox75;
            txt9[8, 3] = textBox76;
            txt9[8, 4] = textBox77;
            txt9[8, 5] = textBox78;
            txt9[8, 6] = textBox79;
            txt9[8, 7] = textBox80;
            txt9[8, 8] = textBox81;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    btn9[i, j].Visible = false;
                    txt9[i, j].Visible = false;
                }
            }

            //cek setting
            stg = 5;
            string a;
            string[] b;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    btn5[i, j].Visible = true;
                    txt5[i, j].Visible = true;
                }
            }

            List<int> ncom = new List<int>();
            Random rnd = new Random();
            int angka;
            bool status = true;
            int tmp;
            for (int i = 0; i < stg * stg; i++)
            {
                do
                {
                    status = true;
                    angka = rnd.Next(1, (stg * stg) + 1);
                    tmp = angka;
                    for (int j = 0; j < i; j++)
                    {
                        if (ncom[j] == tmp) status = false;
                    }
                } while (status == false);
                ncom.Add(tmp);
            }
            player = new int[stg, stg];
            com = new int[stg, stg];
            for (int i = 0; i < stg; i++)
            {
                for (int j = 0; j < stg; j++)
                {
                    com[i, j] = ncom[stg * i + j];
                }
            }

            //masukkan angka
            StreamReader sr2 = new StreamReader("angka.txt");
            a = sr2.ReadLine();
            b = a.Split();

            //tergantung setting
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    btn5[i, j].Text = b[5 * i + j];
                    player[i, j] = Convert.ToInt32(b[5 * i + j]);
                    txt5[i, j].Text = com[i, j].ToString();
                }
            }
            sr2.Close();
            File.Delete("angka.txt");
        }

        private void BINGO_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public int cek(int[,] posisi)
        {
            int hitung = 0;
            //cek horizontal
            for (int i = 0; i < stg; i++)
            {
                for (int j = 0; j < stg; j++)
                {
                    if (posisi[i, j] == 0) hitung++;
                }
            }
            //cek vertikal
            for (int i = 0; i < stg; i++)
            {
                for (int j = 0; j < stg; j++)
                {
                    if (posisi[j, i] == 0) hitung++;
                }
            }
            //cek diagonal (kiri ke kanan) (x=y)
            for (int i = 0; i < stg; i++)
            {
                if (posisi[i, i] == 0) hitung++;
            }
            //cek diagonal (kanan ke kiri)(x=stg-1-y)
            for (int i = 0; i < stg; i++)
            {
                if (posisi[i, stg - 1 - i] == 0) hitung++;
            }
            return hitung;
        }
        public void main2(int xstg)
        {
            int temp;
            bool status;
            if (tingkat == 1) status = false;
            else if (tingkat == 3) status = false;
            else status = true;

            //insert algoritma
            temp = alphabeta(com, tingkat + 1, -15000, 15000, status);

            foreach (Control item in Controls)
            {
                if(item is Button)
                {
                    if (Convert.ToInt32(item.Text) == angkacom)
                    {
                        item.Enabled = false;
                        item.BackColor = Color.Yellow;
                    }
                }
            }
            int kx = 0;
            int ky = 0;
            for (int i = 0; i < stg; i++)
            {
                for (int j = 0; j < stg; j++)
                {
                    if (angkacom == player[i, j])
                    {
                        kx = i;
                        ky = j;
                    }
                }
            }
            player[kx, ky] = 0;
            pplayer += mcek(kx, ky, player, 1);
            kx = 0;
            ky = 0;
            for (int i = 0; i < stg; i++)
            {
                for (int j = 0; j < stg; j++)
                {
                    if (angkacom == com[i, j])
                    {
                        kx = i;
                        ky = j;
                    }
                }
            }
            com[kx, ky] = 0;

            //ubah warna
            txt5[kx, ky].BackColor = Color.Yellow;

            label8.Text = angkacom.ToString();
            pcom += mcek(kx, ky, com, 2);
            turn++;
            if ((pplayer >= stg) | (pcom >= stg)) stop = true;
            if (stop) selesai();
        }

        public int alphabeta(int[,] node, int depth, int alpha, int beta, bool maximixingPlayer)
        {
            int bantu = 0;
            int v = 0;
            //jika kedalaman=0 maka return nilai bobot dari node
            if (depth == 0) return cek(node);

            int[,] child = new int[stg, stg];
            for (int i = 0; i < stg; i++)
            {
                for (int j = 0; j < stg; j++) child[i, j] = node[i, j];
            }
            if (maximixingPlayer)
            {
                //v=-infinite
                v = -15000;
                for (int i = 0; i < stg; i++)
                {
                    for (int j = 0; j < stg; j++)
                    {
                        if (node[i, j] != 0)
                        {
                            child[i, j] = 0;
                            bantu = alphabeta(child, depth - 1, alpha, beta, false);
                            if (v < bantu) v = bantu;
                            if (alpha < v) angkacom = node[i, j];
                            if (alpha < v) alpha = v;
                            child[i, j] = node[i, j];
                            if (beta >= alpha) break;
                        }
                    }
                }
            }
            else
            {
                //v=infinite
                v = 15000;
                for (int i = 0; i < stg; i++)
                {
                    for (int j = 0; j < stg; j++)
                    {
                        if (node[i, j] != 0)
                        {
                            child[i, j] = 0;
                            bantu = alphabeta(child, depth - 1, alpha, beta, true);
                            if (v > bantu) v = bantu;
                            if (beta > v) angkacom = node[i, j];
                            if (beta > v) beta = v;
                            child[i, j] = node[i, j];
                            if (beta >= alpha) break;
                        }
                    }
                }
            }
            return v;
        }
    }
}
