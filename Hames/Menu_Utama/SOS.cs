using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu_Utama
{
  public partial class SOS : Form
  {
    TextBox[,] alanlar;
    int Baris = 0, Kolom = 0;

    public SOS()
    {
      InitializeComponent();
    }

    private void SOS_Load(object sender, EventArgs e)
    {
      Baris = 3;
      Kolom = 3;
    }

    void yenitextBox_KeyUp(object sender, KeyEventArgs e)
    {
      this.Focus();
      TextBox text = sender as TextBox;
      label1.Focus();

      if (text.TextLength > 1)
        text.Text = text.Text.Substring(0, 1);
      else
      {
        text.Text = text.Text.ToUpper();

        bool sosOlduMu = false;
        for (int i = 0; i < Baris; i++)
        {
          for (int j = 0; j < Kolom; j++)
          {
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i, j + 1].Text == "O" && alanlar[i, j + 2].Text == "S")
                sosOlduMu = true;
            }
            catch (Exception) { }
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i, j - 1].Text == "O" && alanlar[i, j - 2].Text == "S")
                sosOlduMu = true;
            }
            catch (Exception) { }
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i + 1, j].Text == "O" && alanlar[i + 2, j].Text == "S")
                sosOlduMu = true;
            }
            catch (Exception) { }
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i - 1, j].Text == "O" && alanlar[i - 2, j].Text == "S")
                sosOlduMu = true;
            }
            catch (Exception) { }
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i + 1, j + 1].Text == "O" && alanlar[i + 2, j + 2].Text == "S")
                sosOlduMu = true;
            }
            catch (Exception) { }
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i + 1, j - 1].Text == "O" && alanlar[i + 2, j - 2].Text == "S")
                sosOlduMu = true;
            }
            catch (Exception) { }
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i - 1, j - 1].Text == "O" && alanlar[i - 2, j - 2].Text == "S")
                sosOlduMu = true;
            }
            catch (Exception) { }
            try
            {
              if (alanlar[i, j].Text == "S" && alanlar[i - 1, j + 1].Text == "O" && alanlar[i - 2, j + 2].Text == "S")


                sosOlduMu = true;
            }
            catch (Exception) { }

          }
          if (sosOlduMu)
          {
            MessageBox.Show("SOS :" + text.Text + " OYUNCUSU OYUNUU KAZANDI.", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);

            break;
          }
        }

        if (sosOlduMu)
        {
          for (int i = 0; i < Baris; i++)
          {
            for (int j = 0; j < Kolom; j++)
            {
              alanlar[i, j].Enabled = false;
            }

          }
        }

      }
    }

    private void nud1_ValueChanged(object sender, EventArgs e)
    {
      if (nud1.Value < 3)
        nud1.Value = 3;

      Baris = Convert.ToInt32(nud1.Value);
    }

    private void nud2_ValueChanged(object sender, EventArgs e)
    {
      if (nud2.Value < 3)
        nud2.Value = 3;

      Kolom = Convert.ToInt32(nud2.Value);
    }
    int A = 0;

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void start_Click(object sender, EventArgs e)
    {
      A = 10;
      for (int i = 0; i < Baris; i++)
      {
        for (int j = 0; j < Kolom; j++)
        {
          try
          {
            alanlar[i, j].Visible = false;
          }
          catch (Exception)
          {

          }
        }
      }

      alanlar = new TextBox[Baris, Kolom];

      for (int i = 0; i < Baris; i++)
      {
        for (int j = 0; j < Kolom; j++)
        {

          TextBox yenitextBox = new TextBox();
          yenitextBox.Location = new System.Drawing.Point(A + j * 25 + 25, i * 25 + 100);
          yenitextBox.Name = i + " * " + j;
          yenitextBox.Size = new System.Drawing.Size(20, 20);
          yenitextBox.TabIndex = 1;
          yenitextBox.BorderStyle = BorderStyle.FixedSingle;

          yenitextBox.KeyUp += new KeyEventHandler(yenitextBox_KeyUp);
          this.Controls.Add(yenitextBox);
          alanlar[i, j] = yenitextBox;
        }
      }
    }
  }

}

