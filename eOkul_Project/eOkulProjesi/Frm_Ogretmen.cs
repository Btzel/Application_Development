using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOkulProjesi
{
    public partial class Frm_Ogretmen : Form
    {
        public Frm_Ogretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Kulupİslem git = new Frm_Kulupİslem();
            git.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Dersİslem git = new Frm_Dersİslem();
            git.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Ogrenciİslem git = new Frm_Ogrenciİslem();
            git.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_SinavNotlari git = new Frm_SinavNotlari();
            git.Show();
        }
    }
}
