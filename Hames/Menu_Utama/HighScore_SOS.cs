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
  }
}
