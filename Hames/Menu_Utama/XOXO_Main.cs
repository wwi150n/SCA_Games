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
    public partial class XOXO_Main : Form
    {
        public XOXO_Main()
        {
            InitializeComponent();
            if (File.Exists("History.txt"))
            {
                StreamReader sr = new StreamReader("History.txt");
                string a;
                List<string> temp = new List<string>();
                do
                {
                    a = sr.ReadLine();
                    temp.Add(a);
                } while (!sr.EndOfStream);
                sr.Close();
                for (int i = temp.Count-1; i > -1; i--)
                {
                    listBox1.Items.Add(temp[i]);
                }
                
            }
        }

        private void XOXO_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XOXO_Menu frm = new XOXO_Menu();
            this.Hide();
            frm.Show();
        }
    }
}
