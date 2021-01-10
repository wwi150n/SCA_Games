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
  public partial class HighScore_SOS : Form
  {
    public HighScore_SOS()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SOS_Menu Sos = new SOS_Menu();
      this.Hide();
      Sos.Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void HighScore_SOS_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void HighScore_SOS_Load(object sender, EventArgs e)
    {
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
        textBox1.Text = a;
      }
    }
  }
}
