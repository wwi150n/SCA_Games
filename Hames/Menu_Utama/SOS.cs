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
    public partial class SOS: Form
    {
        public SOS()
        {
            InitializeComponent();
        }
    private bool bsWasClicked = false;
    private bool boWasClicked = false;

    private void b1_Click(object sender, EventArgs e)
    {
    
      
      if (bsWasClicked)
      {
        b1.Text = "S";
        b1.Enabled = false;
      }
      else if (boWasClicked)
      {
        b1.Text = "O";
        b1.Enabled = false;
      }
      else
      {
        b1.Text = "";
        b1.Enabled = false;
      }

    }

    private void bS_Click(object sender, EventArgs e)
    {
      bsWasClicked = true;
    }

    private void bO_Click(object sender, EventArgs e)
    {
      boWasClicked = true;
  }
  }
}
