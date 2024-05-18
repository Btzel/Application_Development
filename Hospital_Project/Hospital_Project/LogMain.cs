using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hospital_Project
{
    public partial class LogMain : Form
    {
        public LogMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_PatientLog to = new Frm_PatientLog();
            to.Show();
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Frm_DoctorLog to = new Frm_DoctorLog();
            to.Show();
            this.Hide();
        }

        private void btnSecretary_Click(object sender, EventArgs e)
        {
            Frm_SecretaryLog to = new Frm_SecretaryLog();
            to.Show();
            this.Hide();
        }

       
    }
}
