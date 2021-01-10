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
      if (File.Exists("pemenang.txt"))
      {
        string a;
        string[] c;
        string[] d;
        StreamReader sr = new StreamReader("pemenang.txt");
        a = sr.ReadLine();
        c = a.Split();
        sr.Close();
        textBox1.Enabled = false;
        textBox1.Text = a;
      }
    }
  }
}
