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
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
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
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
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
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
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
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
              }
            }
          }
          //cek miring kiri
          if (kolom >= 3 && baris <= 9)
          {
            if (((var[baris + 1, kolom + 1]) == 0) && ((var[baris, kolom]) == 1))
            {
              if (gantian == 1)
              {
                scorePemain1 += 1;
                scoreP1.Text = Convert.ToString(scorePemain1);
                x.BackColor = Color.AliceBlue;
              }
              else if (gantian == 0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
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
              }
              else if (gantian==0)
              {
                scorePemain2 += 1;
                scoreP2.Text = Convert.ToString(scorePemain2);
                x.BackColor = Color.Gold;
              }
            }
            //cek bawah
            if ((baris != 0) && (baris != 11))
            {
              if (((var[baris - 1, kolom]) == 1) && ((var[baris + 1, kolom]) == 1))
              {
                if (gantian == 1)
                {
                  scorePemain1 += 1;
                  scoreP1.Text = Convert.ToString(scorePemain1);
                  //ubah warna "O"
                  x.BackColor = Color.AliceBlue;
                }
                else if (gantian == 0)
                {
                  scorePemain2 += 1;
                  scoreP2.Text = Convert.ToString(scorePemain2);
                  x.BackColor = Color.Gold;
                }
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
      Application.Exit();
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
    }
  }
}
