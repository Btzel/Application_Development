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
    public partial class Frm_SecretaryLog : Form
    {
        public Frm_SecretaryLog()
        {
            InitializeComponent();
        }
        Cls_SqlConnection apply = new Cls_SqlConnection();
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Secretaries where SecretaryTC=@p1 and SecretaryPassword=@p2", apply.connection());
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Frm_SecretaryDetail to = new Frm_SecretaryDetail();
                to.tc = mskTC.Text;
                to.Show();
                this.Hide();
                MessageBox.Show("Welcome to the system..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your TC or Password is wrong. Please try again..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
            
        }

        private void Frm_SecretaryLog_Load(object sender, EventArgs e)
        {

        }
    }
}
