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
    public partial class Frm_PatientEditInfo : Form
    {
        public Frm_PatientEditInfo()
        {
            InitializeComponent();
        }
        Cls_SqlConnection apply = new Cls_SqlConnection();
        public string tc2;
        private void Frm_PatientEditInfo_Load(object sender, EventArgs e)
        {
            mskTC2.Text = tc2;
            SqlCommand command = new SqlCommand("Select PatientName,PatientSurname,PatientPhone,PatientPassword,PatientGender from Tbl_Patients where PatientTc=" + tc2, apply.connection());

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtName.Text = dr[0].ToString();
                txtSurname.Text = dr[1].ToString();
                mskPhone.Text = dr[2].ToString();
                txtPassword.Text = dr[3].ToString();
                cmbGender.Text = dr[4].ToString();
            }
            apply.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //Update
            SqlCommand command2 = new SqlCommand("Update Tbl_Patients set PatientName=@p1, PatientSurname=@p2, PatientPassword=@p3, PatientPhone=@p4, PatientGender=@p5 where PatientTC='" + tc2 + "'", apply.connection());
            command2.Parameters.AddWithValue("@p1", txtName.Text);
            command2.Parameters.AddWithValue("@p2", txtSurname.Text);
            command2.Parameters.AddWithValue("@p3", txtPassword.Text);
            command2.Parameters.AddWithValue("@p4", mskPhone.Text);
            command2.Parameters.AddWithValue("@p5", cmbGender.Text);

            command2.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Your information is updated..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_PatientLog to = new Frm_PatientLog();
            to.Show();
            this.Hide();
        }
    }
}
