using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Project
{
    public partial class Frm_PatientLog : Form
    {
        public Frm_PatientLog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_SignUp to = new Frm_SignUp();
            to.Show();
            this.Hide();
        }
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1 and PatientPassword=@p2",apply.connection());
            
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);

            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                Frm_PatientDetail to = new Frm_PatientDetail();
                
                to.tc = mskTC.Text;
                to.Show();
                this.Hide();
                MessageBox.Show("Welcome to your details..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Your TC or password is wrong. Try again please..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_PatientLog_Load(object sender, EventArgs e)
        {

        }
    }
}
