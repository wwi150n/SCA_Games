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
    public partial class SOS: Form
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
    private bool bsWasClicked = false;
    private bool boWasClicked = false;
    public void main1(object sender, EventArgs e)
    {
      int[,] var = new int[12, 12];
      int temp;
      Button x = ((Button)sender);
      x.Enabled = false;
      x.BackColor = Color.Yellow;
      temp = Convert.ToInt32(x.Name);
      int baris, kolom;
      baris = temp / 12;
      kolom = temp % 12;
      if(bsWasClicked)
      {
        var[baris, kolom] = 1;
      }
      else
      {
        var[baris, kolom] = 0;
      }
      
    }

    private void b001_Click(object sender, EventArgs e)
    {
    
      
      if (bsWasClicked)
      {
        b001.Text = "S";
        b001.Enabled = false;
      }
      else if (boWasClicked)
      {
        b001.Text = "O";
        b001.Enabled = false;
      }
      else
      {
        b001.Text = "";
        b001.Enabled = false;
      }

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
    }
  }
}
