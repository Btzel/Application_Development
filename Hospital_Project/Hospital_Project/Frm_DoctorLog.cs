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
    public partial class Frm_DoctorLog : Form
    {
        public Frm_DoctorLog()
        {
            InitializeComponent();
        }
        
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Doctors where DoctorTC=@p1 and DoctorPassword=@p2", apply.connection());
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Frm_DoctorDetail to = new Frm_DoctorDetail();
                to.tc3 = mskTC.Text;
                to.Show();
                this.Hide();
                MessageBox.Show("Welcome to the system Doctor..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong TC or Password. Please, try again..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            apply.connection().Close();
            
        }

        private void Frm_DoctorLog_Load(object sender, EventArgs e)
        {

        }
    }
}
