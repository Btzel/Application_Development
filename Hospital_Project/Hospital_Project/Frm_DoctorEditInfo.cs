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
    public partial class Frm_DoctorEditInfo : Form
    {
        public Frm_DoctorEditInfo()
        {
            InitializeComponent();
        }
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p5 where DoctorTC=@p4", apply.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbBranch.Text);
            command.Parameters.AddWithValue("@p4", mskTC.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Doctor is updated..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string tc;
        
        private void Frm_DoctorEditInfo_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("Select * from Tbl_Doctors where DoctorTC=@p1", apply.connection());
            command.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
                mskTC.Text = tc;

            }
        }
    }
}
