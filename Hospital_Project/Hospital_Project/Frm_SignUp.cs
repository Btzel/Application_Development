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
    public partial class Frm_SignUp : Form
    {
        public Frm_SignUp()
        {
            InitializeComponent();
        }

        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Patients (PatientName,PatientSurname,PatientTC,PatientPhone,PatientPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", apply.connection());

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskTC.Text);
            command.Parameters.AddWithValue("@p4", mskPhone.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            command.Parameters.AddWithValue("@p6", cmbGender.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Your registration is completed. Your Password: " + txtPassword.Text , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Frm_PatientLog to = new Frm_PatientLog();
            to.Show();
            this.Hide();
      }

        private void Frm_SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
