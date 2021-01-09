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
    public partial class SOS_Menu : Form
    {
        public SOS_Menu()
        {
            InitializeComponent();
        }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      HighScore_SOS frm = new HighScore_SOS();
      this.Hide();
      frm.Show();
      if (File.Exists("nama.txt") && File.Exists("nama2.txt"))
      {
        string a, b;
        string[] c;
        string[] d;
        StreamReader sr = new StreamReader("nama.txt");
        StreamReader sr2 = new StreamReader("nama2.txt");
        a = sr.ReadLine();
        b = sr2.ReadLine();
        c = a.Split();
        d = b.Split();
        sr.Close();
        sr2.Close();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!File.Exists("nama.txt"))
      {
        File.Create("nama.txt").Close();
      }
      StreamWriter sw = new StreamWriter("nama.txt");
      sw.Write("{0} ", textBox1.Text);
      sw.Close();
      if (!File.Exists("nama2.txt"))
      {
        File.Create("nama2.txt").Close();
      }
      StreamWriter sw2 = new StreamWriter("nama2.txt");
      sw2.Write("{0} ", textBox2.Text);
      sw2.Close();
      SOS sOS = new SOS();
      this.Hide();
      sOS.Show();
      
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Help dokumentasi = new Help();
      this.Hide();
      dokumentasi.Show();
    }

    private void SOS_Menu_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
