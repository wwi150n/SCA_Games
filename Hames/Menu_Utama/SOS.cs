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
  public partial class SOS : Form
  {
    public SOS()
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
    private bool bsWasClicked = true;
    private bool boWasClicked = false;
    public int giliran = 1;
    public int scorePemain1 = 0;
    public int scorePemain2 = 0;
    public int[,] var = new int[12, 12];
    public Button[,] btn = new Button[12, 12];

    public void main1(object sender, EventArgs e)
    {
      string temp;
      string pemain1, pemain2;
      pemain1 = label1.Text;
      pemain2 = label2.Text;
      Button x = ((Button)sender);
      x.Enabled = false;
      temp = x.Name.ToString();
      int baris, kolom;
      int angka;
      int gantian;
      gantian = giliran % 2;
      angka = Convert.ToInt32(temp.Remove(0, 1));
      baris = (angka - 1) / 12;
      kolom = (angka - 1) % 12;
      
      if (baris != 12)
      {
        if (bsWasClicked)
        {
          var[baris, kolom] = 1;
          x.Text = "S";
          //cek horizontal kiri
          if (kolom >=2)
          {
            if (((var[baris, kolom - 1]) == 0) && ((var[baris, kolom - 2]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris, kolom - 1].BackColor = Color.AliceBlue;
                btn[baris, kolom - 2].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris, kolom - 1].BackColor = Color.Gold;
                btn[baris, kolom - 2].BackColor = Color.Gold;
              }
            }
          }
          //cek horizontal kanan
          if (kolom <= 9)
          {
            if (((var[baris, kolom + 1]) == 0) && ((var[baris, kolom + 2]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris, kolom + 1].BackColor = Color.AliceBlue;
                btn[baris, kolom + 2].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris, kolom + 1].BackColor = Color.Gold;
                btn[baris, kolom + 2].BackColor = Color.Gold;
              }
            }
          }
          //cek atas
          if (baris >= 2)
          {
            if (((var[baris-1, kolom]) == 0) && ((var[baris-2, kolom]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris - 1, kolom].BackColor = Color.AliceBlue;
                btn[baris - 2, kolom].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris - 1, kolom].BackColor = Color.Gold;
                btn[baris - 2, kolom].BackColor = Color.Gold;
              }
            }
          }
          //cek bawah
          if (baris <=9)
          {
            if (((var[baris+1, kolom]) == 0) && ((var[baris+2, kolom]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris + 1, kolom].BackColor = Color.AliceBlue;
                btn[baris + 2, kolom].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris + 1, kolom].BackColor = Color.Gold;
                btn[baris + 2, kolom].BackColor = Color.Gold;
              }
            }
          }
          //cek miring kiri atas
          if ((kolom >= 2) && (baris >=2))
          {
            if (((var[baris - 1, kolom - 1]) == 0) && ((var[baris-2, kolom-2]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris - 1, kolom - 1].BackColor = Color.AliceBlue;
                btn[baris - 2, kolom - 2].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris - 1, kolom - 1].BackColor = Color.Gold;
                btn[baris - 2, kolom - 2].BackColor = Color.Gold;
              }
            }
          }
          //cek miring kiri bawah
          if ((kolom >= 2) && (baris <=9))
          {
            if (((var[baris + 1, kolom - 1]) == 0) && ((var[baris + 2, kolom - 2]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris + 1, kolom - 1].BackColor = Color.AliceBlue;
                btn[baris + 2, kolom - 2].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris + 1, kolom - 1].BackColor = Color.Gold;
                btn[baris + 2, kolom - 2].BackColor = Color.Gold;
              }
            }
          }
          //cek miring kanan bawah
          if ((kolom <= 9) && (baris <= 9))
          {
            if (((var[baris + 1, kolom + 1]) == 0) && ((var[baris + 2, kolom + 2]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris + 1, kolom + 1].BackColor = Color.AliceBlue;
                btn[baris + 2, kolom + 2].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris + 1, kolom + 1].BackColor = Color.Gold;
                btn[baris + 2, kolom + 2].BackColor = Color.Gold;
              }
            }
          }
          //cek miring kanan atas
          if ((kolom <= 9) && (baris >= 2))
          {
            if (((var[baris - 1, kolom + 1]) == 0) && ((var[baris - 2, kolom + 2]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
                btn[baris - 1, kolom + 1].BackColor = Color.AliceBlue;
                btn[baris - 2, kolom + 2].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris - 1, kolom + 1].BackColor = Color.Gold;
                btn[baris - 2, kolom + 2].BackColor = Color.Gold;
              }
            }
          }
          b145.Enabled = true;
          b146.Enabled = true;
          b145.BackColor = Color.Green;
          b146.BackColor = Color.White;
        }
        else
        {
          var[baris, kolom] = 0;
          x.Text = "O";
          //cek horizontal
          if ((kolom != 0) && (kolom != 11))
          {
            if (((var[baris, kolom - 1]) == 1) && ((var[baris, kolom + 1]) == 1))
            {
              if (gantian==1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                //ubah warna "O"
                x.BackColor = Color.AliceBlue;
                btn[baris, kolom - 1].BackColor = Color.AliceBlue;
                btn[baris, kolom + 1].BackColor = Color.AliceBlue;
              }
              else if (gantian==0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris, kolom - 1].BackColor = Color.Gold;
                btn[baris, kolom + 1].BackColor = Color.Gold;
              }
            }
            
            //cek diagonal
            if ((baris != 0) && (baris != 11))
            {
              //kanan
              if (((var[baris-1, kolom-1]) == 1) && ((var[baris + 1, kolom+1]) == 1))
              {
                if (gantian == 1)
                {
                  scorePemain1 += 1;
                  scoreP1.Text = Convert.ToString(scorePemain1);
                  //ubah warna "O"
                  x.BackColor = Color.AliceBlue;
                  btn[baris - 1, kolom - 1].BackColor = Color.AliceBlue;
                  btn[baris + 1, kolom + 1].BackColor = Color.AliceBlue;
                }
                else if (gantian == 0)
                {
                  scorePemain2 += 1;
                  scoreP2.Text = Convert.ToString(scorePemain2);
                  x.BackColor = Color.Gold;
                  btn[baris - 1, kolom - 1].BackColor = Color.Gold;
                  btn[baris + 1, kolom + 1].BackColor = Color.Gold;
                }
              }
            }
            //cek diagonal
            if ((baris != 0) && (baris != 11))
            {
              //kiri
              if (((var[baris - 1, kolom + 1]) == 1) && ((var[baris + 1, kolom - 1]) == 1))
              {
                if (gantian == 1)
                {
                  scorePemain1 += 1;
                  scoreP1.Text = Convert.ToString(scorePemain1);
                  //ubah warna "O"
                  x.BackColor = Color.AliceBlue;
                  btn[baris - 1, kolom + 1].BackColor = Color.AliceBlue;
                  btn[baris + 1, kolom - 1].BackColor = Color.AliceBlue;
                }
                else if (gantian == 0)
                {
                  scorePemain2 += 1;
                  scoreP2.Text = Convert.ToString(scorePemain2);
                  x.BackColor = Color.Gold;
                  btn[baris - 1, kolom + 1].BackColor = Color.Gold;
                  btn[baris + 1, kolom - 1].BackColor = Color.Gold;
                }
              }
            }
          }
          //cek bawah
          if ((baris >= 1) && (baris <= 10))
          {
            if (((var[baris - 1, kolom]) == 1) && ((var[baris + 1, kolom]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                //ubah warna "O"
                x.BackColor = Color.AliceBlue;
                btn[baris - 1, kolom].BackColor = Color.AliceBlue;
                btn[baris + 1, kolom].BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
                btn[baris - 1, kolom].BackColor = Color.Gold;
                btn[baris + 1, kolom].BackColor = Color.Gold;
              }
            }
          }

          b145.Enabled = true;
          b146.Enabled = true;
          b146.BackColor = Color.Green;
          b145.BackColor = Color.White;        
        }
        giliran += 1;
      }
      else
      {
        if (bsWasClicked)
        {
          b145.BackColor = Color.Green;
          b146.BackColor = Color.White;
        }
        else if (boWasClicked)
        {
          b145.BackColor = Color.White;
          b146.BackColor = Color.Green;
        }
      }
      if (gantian != 1)
      {
        pemain2 = label2.Text;
        label2.ForeColor = Color.Red;
        label1.ForeColor = Color.Black;
      }
      else
      {
        pemain1 = label1.Text;
        label1.ForeColor = Color.Red;
        label2.ForeColor = Color.Black;
      }
        
    }

  
     private void b001_Click(object sender, EventArgs e)
    {
    
    }

    private void bS_Click(object sender, EventArgs e)
    {
      bsWasClicked = true;
      boWasClicked = false;
    }

    private void bO_Click(object sender, EventArgs e)
    {
      boWasClicked = true;
      bsWasClicked = false;
  }

    private void S_Click(object sender, EventArgs e)
    {
      if(scorePemain1>scorePemain2)
      {
        MessageBox.Show(label1.Text + "Menang !!! Dengan Score : " + scorePemain1.ToString());
        HighScore_SOS frm = new HighScore_SOS();
        this.Hide();
        frm.Show();
      }
      else
      {
        MessageBox.Show(label2.Text + "Menang !!! Dengan Score : " + scorePemain2.ToString());
        HighScore_SOS frm = new HighScore_SOS();
        this.Hide();
        frm.Show();
      }
    }

    private void SOS_Load(object sender, EventArgs e)
    {
      StreamReader sr = new StreamReader("nama.txt");
      label1.Text = sr.ReadLine();
      sr.Close();
      StreamReader sr2 = new StreamReader("nama2.txt");
      label2.Text = sr2.ReadLine();
      sr2.Close();
      for (int i = 0; i < 12; i++)
      {
        for (int j = 0; j < 12; j++)
        {
          var[i, j] = 2;
        }
      }
      btn[0, 0] = b001;
      btn[0, 1] = b002;
      btn[0, 2] = b003;
      btn[0, 3] = b004;
      btn[0, 4] = b005;
      btn[0, 5] = b006;
      btn[0, 6] = b007;
      btn[0, 7] = b008;
      btn[0, 8] = b009;
      btn[0, 9] = b010;
      btn[0, 10] = b011;
      btn[0, 11] = b012;
      btn[1, 0] = b013;
      btn[1, 1] = b014;
      btn[1, 2] = b015;
      btn[1, 3] = b016;
      btn[1, 4] = b017;
      btn[1, 5] = b018;
      btn[1, 6] = b019;
      btn[1, 7] = b020;
      btn[1, 8] = b021;
      btn[1, 9] = b022;
      btn[1, 10] = b023;
      btn[1, 11] = b024;
      btn[2, 0] = b025;
      btn[2, 1] = b026;
      btn[2, 2] = b027;
      btn[2, 3] = b028;
      btn[2, 4] = b029;
      btn[2, 5] = b030;
      btn[2, 6] = b031;
      btn[2, 7] = b032;
      btn[2, 8] = b033;
      btn[2, 9] = b034;
      btn[2, 10] = b035;
      btn[2, 11] = b036;
      btn[3, 0] = b037;
      btn[3, 1] = b038;
      btn[3, 2] = b039;
      btn[3, 3] = b040;
      btn[3, 4] = b041;
      btn[3, 5] = b042;
      btn[3, 6] = b043;
      btn[3, 7] = b044;
      btn[3, 8] = b045;
      btn[3, 9] = b046;
      btn[3, 10] = b047;
      btn[3, 11] = b048;
      btn[4, 0] = b049;
      btn[4, 1] = b050;
      btn[4, 2] = b051;
      btn[4, 3] = b052;
      btn[4, 4] = b053;
      btn[4, 5] = b054;
      btn[4, 6] = b055;
      btn[4, 7] = b056;
      btn[4, 8] = b057;
      btn[4, 9] = b058;
      btn[4, 10] = b059;
      btn[4, 11] = b060;
      btn[5, 0] = b061;
      btn[5, 1] = b062;
      btn[5, 2] = b063;
      btn[5, 3] = b064;
      btn[5, 4] = b065;
      btn[5, 5] = b066;
      btn[5, 6] = b067;
      btn[5, 7] = b068;
      btn[5, 8] = b069;
      btn[5, 9] = b070;
      btn[5, 10] = b071;
      btn[5, 11] = b072;
      btn[6, 0] = b073;
      btn[6, 1] = b074;
      btn[6, 2] = b075;
      btn[6, 3] = b076;
      btn[6, 4] = b077;
      btn[6, 5] = b078;
      btn[6, 6] = b079;
      btn[6, 7] = b080;
      btn[6, 8] = b081;
      btn[6, 9] = b082;
      btn[6, 10] = b083;
      btn[6, 11] = b084;
      btn[7, 0] = b085;
      btn[7, 1] = b086;
      btn[7, 2] = b087;
      btn[7, 3] = b088;
      btn[7, 4] = b089;
      btn[7, 5] = b090;
      btn[7, 6] = b091;
      btn[7, 7] = b092;
      btn[7, 8] = b093;
      btn[7, 9] = b094;
      btn[7, 10] = b095;
      btn[7, 11] = b096;
      btn[8, 0] = b097;
      btn[8, 1] = b098;
      btn[8, 2] = b099;
      btn[8, 3] = b100;
      btn[8, 4] = b101;
      btn[8, 5] = b102;
      btn[8, 6] = b103;
      btn[8, 7] = b104;
      btn[8, 8] = b105;
      btn[8, 9] = b106;
      btn[8, 10] = b107;
      btn[8, 11] = b108;
      btn[9, 0] = b109;
      btn[9, 1] = b110;
      btn[9, 2] = b111;
      btn[9, 3] = b112;
      btn[9, 4] = b113;
      btn[9, 5] = b114;
      btn[9, 6] = b115;
      btn[9, 7] = b116;
      btn[9, 8] = b117;
      btn[9, 9] = b118;
      btn[9, 10] = b119;
      btn[9, 11] = b120;
      btn[10, 0] = b121;
      btn[10, 1] = b122;
      btn[10, 2] = b123;
      btn[10, 3] = b124;
      btn[10, 4] = b125;
      btn[10, 5] = b126;
      btn[10, 6] = b127;
      btn[10, 7] = b128;
      btn[10, 8] = b129;
      btn[10, 9] = b130;
      btn[10, 10] = b131;
      btn[10, 11] = b132;
      btn[11, 0] = b133;
      btn[11, 1] = b134;
      btn[11, 2] = b135;
      btn[11, 3] = b136;
      btn[11, 4] = b137;
      btn[11, 5] = b138;
      btn[11, 6] = b139;
      btn[11, 7] = b140;
      btn[11, 8] = b141;
      btn[11, 9] = b142;
      btn[11, 10] = b143;
      btn[11, 11] = b144;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      SOS_Menu Sos = new SOS_Menu();
      this.Hide();
      Sos.Show();
    }

    private void SOS_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
