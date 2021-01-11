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
            A226.BackColor = Color.Green;
            reset1();
            btn[0, 0] = A001;
            btn[0, 1] = A002;
            btn[0, 2] = A003;
            btn[0, 3] = A004;
            btn[0, 4] = A005;
            btn[0, 5] = A006;
            btn[0, 6] = A007;
            btn[0, 7] = A008;
            btn[0, 8] = A009;
            btn[0, 9] = A010;
            btn[0, 10] = A011;
            btn[0, 11] = A012;
            btn[0, 12] = A013;
            btn[0, 13] = A014;
            btn[0, 14] = A015;
            btn[1, 0] = A016;
            btn[1, 1] = A017;
            btn[1, 2] = A018;
            btn[1, 3] = A019;
            btn[1, 4] = A020;
            btn[1, 5] = A021;
            btn[1, 6] = A022;
            btn[1, 7] = A023;
            btn[1, 8] = A024;
            btn[1, 9] = A025;
            btn[1, 10] = A026;
            btn[1, 11] = A027;
            btn[1, 12] = A028;
            btn[1, 13] = A029;
            btn[1, 14] = A030;
            btn[2, 0] = A031;
            btn[2, 1] = A032;
            btn[2, 2] = A033;
            btn[2, 3] = A034;
            btn[2, 4] = A035;
            btn[2, 5] = A036;
            btn[2, 6] = A037;
            btn[2, 7] = A038;
            btn[2, 8] = A039;
            btn[2, 9] = A040;
            btn[2, 10] = A041;
            btn[2, 11] = A042;
            btn[2, 12] = A043;
            btn[2, 13] = A044;
            btn[2, 14] = A045;
            btn[3, 0] = A046;
            btn[3, 1] = A047;
            btn[3, 2] = A048;
            btn[3, 3] = A049;
            btn[3, 4] = A050;
            btn[3, 5] = A051;
            btn[3, 6] = A052;
            btn[3, 7] = A053;
            btn[3, 8] = A054;
            btn[3, 9] = A055;
            btn[3, 10] = A056;
            btn[3, 11] = A057;
            btn[3, 12] = A058;
            btn[3, 13] = A059;
            btn[3, 14] = A060;
            btn[4, 0] = A061;
            btn[4, 1] = A062;
            btn[4, 2] = A063;
            btn[4, 3] = A064;
            btn[4, 4] = A065;
            btn[4, 5] = A066;
            btn[4, 6] = A067;
            btn[4, 7] = A068;
            btn[4, 8] = A069;
            btn[4, 9] = A070;
            btn[4, 10] = A071;
            btn[4, 11] = A072;
            btn[4, 12] = A073;
            btn[4, 13] = A074;
            btn[4, 14] = A075;
            btn[5, 0] = A076;
            btn[5, 1] = A077;
            btn[5, 2] = A078;
            btn[5, 3] = A079;
            btn[5, 4] = A080;
            btn[5, 5] = A081;
            btn[5, 6] = A082;
            btn[5, 7] = A083;
            btn[5, 8] = A084;
            btn[5, 9] = A085;
            btn[5, 10] = A086;
            btn[5, 11] = A087;
            btn[5, 12] = A088;
            btn[5, 13] = A089;
            btn[5, 14] = A090;

            btn[6, 0] = A091;
            btn[6, 1] = A092;
            btn[6, 2] = A093;
            btn[6, 3] = A094;
            btn[6, 4] = A095;
            btn[6, 5] = A096;
            btn[6, 6] = A097;
            btn[6, 7] = A098;
            btn[6, 8] = A099;
            btn[6, 9] = A100;
            btn[6, 10] = A101;
            btn[6, 11] = A102;
            btn[6, 12] = A103;
            btn[6, 13] = A104;
            btn[6, 14] = A105;
            btn[7, 0] = A106;
            btn[7, 1] = A107;
            btn[7, 2] = A108;
            btn[7, 3] = A109;
            btn[7, 4] = A110;
            btn[7, 5] = A111;
            btn[7, 6] = A112;
            btn[7, 7] = A113;
            btn[7, 8] = A114;
            btn[7, 9] = A115;
            btn[7, 10] = A116;
            btn[7, 11] = A117;
            btn[7, 12] = A118;
            btn[7, 13] = A119;
            btn[7, 14] = A120;
            btn[8, 0] = A121;
            btn[8, 1] = A122;
            btn[8, 2] = A123;
            btn[8, 3] = A124;
            btn[8, 4] = A125;
            btn[8, 5] = A126;
            btn[8, 6] = A127;
            btn[8, 7] = A128;
            btn[8, 8] = A129;
            btn[8, 9] = A130;
            btn[8, 10] = A131;
            btn[8, 11] = A132;
            btn[8, 12] = A133;
            btn[8, 13] = A134;
            btn[8, 14] = A135;
            btn[9, 0] = A136;
            btn[9, 1] = A137;
            btn[9, 2] = A138;
            btn[9, 3] = A139;
            btn[9, 4] = A140;
            btn[9, 5] = A141;
            btn[9, 6] = A142;
            btn[9, 7] = A143;
            btn[9, 8] = A144;
            btn[9, 9] = A145;
            btn[9, 10] = A146;
            btn[9, 11] = A147;
            btn[9, 12] = A148;
            btn[9, 13] = A149;
            btn[9, 14] = A150;
            btn[10, 0] = A151;
            btn[10, 1] = A152;
            btn[10, 2] = A153;
            btn[10, 3] = A154;
            btn[10, 4] = A155;
            btn[10, 5] = A156;
            btn[10, 6] = A157;
            btn[10, 7] = A158;
            btn[10, 8] = A159;
            btn[10, 9] = A160;
            btn[10, 10] = A161;
            btn[10, 11] = A162;
            btn[10, 12] = A163;
            btn[10, 13] = A164;
            btn[10, 14] = A165;
            btn[11, 0] = A166;
            btn[11, 1] = A167;
            btn[11, 2] = A168;
            btn[11, 3] = A169;
            btn[11, 4] = A170;
            btn[11, 5] = A171;
            btn[11, 6] = A172;
            btn[11, 7] = A173;
            btn[11, 8] = A174;
            btn[11, 9] = A175;
            btn[11, 10] = A176;
            btn[11, 11] = A177;
            btn[11, 12] = A178;
            btn[11, 13] = A179;
            btn[11, 14] = A180;

            btn[12, 0] = A181;
            btn[12, 1] = A182;
            btn[12, 2] = A183;
            btn[12, 3] = A184;
            btn[12, 4] = A185;
            btn[12, 5] = A186;
            btn[12, 6] = A187;
            btn[12, 7] = A188;
            btn[12, 8] = A189;
            btn[12, 9] = A190;
            btn[12, 10] = A191;
            btn[12, 11] = A192;
            btn[12, 12] = A193;
            btn[12, 13] = A194;
            btn[12, 14] = A195;
            btn[13, 0] = A196;
            btn[13, 1] = A197;
            btn[13, 2] = A198;
            btn[13, 3] = A199;
            btn[13, 4] = A200;
            btn[13, 5] = A201;
            btn[13, 6] = A202;
            btn[13, 7] = A203;
            btn[13, 8] = A204;
            btn[13, 9] = A205;
            btn[13, 10] = A206;
            btn[13, 11] = A207;
            btn[13, 12] = A208;
            btn[13, 13] = A209;
            btn[13, 14] = A210;
            btn[14, 0] = A211;
            btn[14, 1] = A212;
            btn[14, 2] = A213;
            btn[14, 3] = A214;
            btn[14, 4] = A215;
            btn[14, 5] = A216;
            btn[14, 6] = A217;
            btn[14, 7] = A218;
            btn[14, 8] = A219;
            btn[14, 9] = A220;
            btn[14, 10] = A221;
            btn[14, 11] = A222;
            btn[14, 12] = A223;
            btn[14, 13] = A224;
            btn[14, 14] = A225;
            StreamReader sr = new StreamReader("Namax.txt");
            string a;
            string[] b;
            a = sr.ReadLine().ToString();
            b = a.Split();
            pemain1 = b[0];
            pemain2 = b[1];
            sr.Close();
            File.Delete("Namax.txt");
            label2.Text = pemain1;
            label3.Text = pemain2;

            StreamReader sr2 = new StreamReader("Peranx.txt");
            a = sr2.ReadLine().ToString();
            b = a.Split();
            pmn[0] = b[0];
            pmn[1] = b[1];
            sr2.Close();
            File.Delete("Peranx.txt");
            A226.Text = pmn[0];
            A227.Text = pmn[1];
            if (pmn[0] == "O") giliran = 0;
            else giliran = 1;
        }

        public int giliran;
        public int nilai = 0;
        public int scorePemain1 = 0;
        public int scorePemain2 = 0;
        public int[,] var = new int[15,15];
        public Button[,] btn = new Button[15, 15];
        public int baris, kolom, poin;
        public string[] pmn = new string[2];
        public string pemain1, pemain2;

        public void main1(object sender, EventArgs e)
        {
            string temp;
            
            
            Button x = ((Button)sender);
            x.Enabled = false;
            temp = x.Name.ToString();
            int angka;
            angka = Convert.ToInt32(temp.Remove(0, 1));
            baris = (angka - 1) / 15;
            kolom = (angka - 1) % 15;
            giliran = giliran % 2;
            if (baris < 15)
            {
                if (giliran==1)
                {
                    var[baris, kolom] = 1;
                    x.Text = "X";
                    A226.BackColor = Color.Red;
                    A227.BackColor = Color.Green;
                    x.BackColor = Color.Yellow;

                    //cek horizontal
                    horizontal(1);

                    //cek vertikal
                    vertikal(1);

                    //cek diagonal
                    diagonal1(1);
                    diagonal2(1);

                    giliran++;
                }
                else
                {
                    var[baris, kolom] = 0;
                    x.Text = "O";
                    A227.BackColor = Color.Red;
                    A226.BackColor = Color.Green;
                    x.BackColor = Color.Yellow;

                    //cek horizontal
                    horizontal(0);

                    //cek vertikal
                    vertikal(0);

                    //cek diagonal
                    diagonal1(0);
                    diagonal2(0);

                    giliran ++;
                }
            }
            else
            {
                
            }
            

        }

        public void horizontal(int pemain)
        {
            int hitung = 1;
            bool kiri = true;
            bool kanan = true;
            poin = 1;
            while (true)
            {
                if (((kolom - hitung) >= 0) && kiri)
                {
                    if (var[baris, kolom - hitung] == pemain)
                    {
                        poin++;
                    }
                    else kiri = false;
                }
                else break;
                hitung++;
            }
            hitung = 1;
            while (true)
            {
                if (((kolom + hitung) <= 14) && kanan)
                {
                    if (var[baris, kolom + hitung] == pemain)
                    {
                        poin++;
                    }
                    else kanan = false;
                }
                else break;
                hitung++;
            }
            if (poin >= 5)
            {
                btn[baris, kolom].BackColor = Color.Green;

                //horizontal kiri
                hitung = 1;
                while (true)
                {
                    if ((kolom - hitung) >= 0)
                    {
                        if (var[baris, kolom - hitung] == pemain)
                        {
                            btn[baris, kolom - hitung].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }

                //horizontal kanan
                hitung = 1;
                while (true)
                {
                    if ((kolom + hitung) <= 14)
                    {
                        if (var[baris, kolom + hitung] ==pemain)
                        {
                            btn[baris, kolom + hitung].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }
                menang(giliran);
                reset();
            }
        }

        public void vertikal(int pemain)
        {
            int hitung = 1;
            bool atas = true;
            bool bawah = true;
            poin = 1;
            while (true)
            {
                if (((baris - hitung) >= 0) && atas)
                {
                    if (var[baris-hitung, kolom] == pemain)
                    {
                        poin++;
                    }
                    else atas = false;
                }
                else break;
                hitung++;
            }
            hitung = 1;
            while (true)
            {
                if (((baris + hitung) <= 14) && bawah)
                {
                    if (var[baris+hitung, kolom] == pemain)
                    {
                        poin++;
                    }
                    else bawah = false;
                }
                else break;
                hitung++;
            }
            if (poin >= 5)
            {
                btn[baris, kolom].BackColor = Color.Green;

                //vertikal atas
                hitung = 1;
                while (true)
                {
                    if ((baris - hitung) >= 0)
                    {
                        if (var[baris-hitung, kolom] == pemain)
                        {
                            btn[baris-hitung, kolom].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }

                //vertikal bawah
                hitung = 1;
                while (true)
                {
                    if ((baris + hitung) <= 14)
                    {
                        if (var[baris+hitung, kolom] == pemain)
                        {
                            btn[baris+hitung, kolom].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }
                menang(giliran);
                reset();
            }
        }

        public void diagonal1(int pemain)
        {
            int hitung = 1;
            bool ataskiri = true;
            bool bawahkanan = true;
            poin = 1;
            while (true)
            {
                if (((kolom - hitung) >= 0) && ((baris-hitung)>=0)&& (ataskiri))
                {
                    if (var[baris-hitung, kolom - hitung] == pemain)
                    {
                        poin++;
                    }
                    else ataskiri = false;
                }
                else break;
                hitung++;
            }
            hitung = 1;
            while (true)
            {
                if (((kolom + hitung) <= 14) && ((baris+hitung)<=14)&& bawahkanan)
                {
                    if (var[baris+hitung, kolom + hitung] == pemain)
                    {
                        poin++;
                    }
                    else bawahkanan = false;
                }
                else break;
                hitung++;
            }
            if (poin >= 5)
            {
                btn[baris, kolom].BackColor = Color.Green;

                //diagonal atas kiri
                hitung = 1;
                while (true)
                {
                    if (((kolom - hitung) >= 0) && ((baris-hitung)>=0))
                    {
                        if (var[baris-hitung, kolom - hitung] == pemain)
                        {
                            btn[baris-hitung, kolom - hitung].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }

                //diagonal bawahkanan
                hitung = 1;
                while (true)
                {
                    if (((kolom + hitung) <= 14) && ((baris+hitung)<=14))
                    {
                        if (var[baris+hitung, kolom + hitung] == pemain)
                        {
                            btn[baris+hitung, kolom + hitung].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }
                menang(giliran);
                reset();
            }
        }

        public void diagonal2(int pemain)
        {
            int hitung = 1;
            bool ataskanan = true;
            bool bawahkiri = true;
            poin = 1;
            while (true)
            {
                if (((kolom - hitung) >= 0) && ((baris + hitung) <=14) && (ataskanan))
                {
                    if (var[baris + hitung, kolom - hitung] == pemain)
                    {
                        poin++;
                    }
                    else ataskanan = false;
                }
                else break;
                hitung++;
            }
            hitung = 1;
            while (true)
            {
                if (((kolom + hitung) <= 14) && ((baris - hitung) >=0) && bawahkiri)
                {
                    if (var[baris - hitung, kolom + hitung] == pemain)
                    {
                        poin++;
                    }
                    else bawahkiri = false;
                }
                else break;
                hitung++;
            }
            if (poin >= 5)
            {
                btn[baris, kolom].BackColor = Color.Green;

                //diagonal atas kanan
                hitung = 1;
                while (true)
                {
                    if (((kolom - hitung) >= 0) && ((baris + hitung) <=14))
                    {
                        if (var[baris + hitung, kolom - hitung] == pemain)
                        {
                            btn[baris + hitung, kolom - hitung].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }

                //diagonal bawahkanan
                hitung = 1;
                while (true)
                {
                    if (((kolom + hitung) <= 14) && ((baris - hitung) >=0))
                    {
                        if (var[baris - hitung, kolom + hitung] == pemain)
                        {
                            btn[baris - hitung, kolom + hitung].BackColor = Color.Green;
                        }
                        else break;
                    }
                    else break;
                    hitung++;
                }
                menang(giliran);
                reset();
            }
        }

        public void reset()
        {
            reset1();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    btn[i, j].BackColor = Color.BlueViolet;
                    btn[i, j].Text = "";
                    btn[i, j].Enabled = true;
                }
            }
            if (pmn[0] == "O") giliran = 1;
            else giliran = 0;
            A226.BackColor = Color.Green;
            A227.BackColor = Color.Red;
        }

        public void reset1()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    var[i, j] = 2;
                }
            }
        }

        public void menang(int giliran)
        {
            if (giliran == 1)
            {
                MessageBox.Show("X menang pada babak ini !!!", "Notifikasi");
                if (pmn[0] == "X")
                {
                    scorePemain1++;
                    scorep1.Text = scorePemain1.ToString();
                }
                else
                {
                    scorePemain2++;
                    scorep2.Text = scorePemain2.ToString();
                }
            }
            else if (giliran == 0)
            {
                MessageBox.Show("O menang pada babak ini !!!", "Notifikasi");
                if (pmn[0]=="O")
                {
                    scorePemain1++;
                    scorep1.Text = scorePemain1.ToString();
                }
                else
                {
                    scorePemain2++;
                    scorep2.Text = scorePemain2.ToString();
                }
            }
            if (scorePemain1 == 2)
            {
                string temp;
                temp = "Permainan selesai !!! " + label2.Text + " memenangkan permainan";
                MessageBox.Show(temp,"Notifikasi");
                
            }
                
            else if (scorePemain2 == 2)
            {
                string temp;
                temp = "Permainan selesai !!! " + label3.Text + " memenangkan permainan";
                MessageBox.Show(temp, "Notifikasi");
            }
                
        }
        private void b01_Click(object sender, EventArgs e)
        {
            
        }



        private void b02_Click(object sender, EventArgs e)
        {
            
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
            
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void XOXO_utama_FontChanged(object sender, EventArgs e)
        {

        }

        private void XOXO_utama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void A009_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    private void XOXO_utama_Load_1(object sender, EventArgs e)
    {

    }
  }
}

    



    

