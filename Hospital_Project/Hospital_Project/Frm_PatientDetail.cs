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
    public partial class Frm_PatientDetail : Form
    {
        public Frm_PatientDetail()
        {
            InitializeComponent();
        }
        public string tc;
        
        
        
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void Frm_PatientDetail_Load(object sender, EventArgs e)
        {
            
            // Name And Surname
            LblTC.Text = tc;
            SqlCommand command = new SqlCommand("Select PatientName,PatientSurname from Tbl_Patients where PatientTC=@p1", apply.connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            apply.connection().Close();

            //Appointment History
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where PatientTC='"+tc+"'",apply.connection());

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branches
            SqlCommand command2 = new SqlCommand("Select BranchName from Tbl_Branches", apply.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
               
            }
            apply.connection().Close();
            
            





        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();

            SqlCommand command3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorBranch=@p1", apply.connection());
            command3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = command3.ExecuteReader();

            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }




        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where AppBranch='"+ cmbBranch.Text +"'" + " and AppDoctor='" + cmbDoctor.Text +"' and AppStatus=0",apply.connection() );
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public string tc2;
        private void lnkEditinformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

        {
            
            Frm_PatientEditInfo to = new Frm_PatientEditInfo();
            to.tc2 = LblTC.Text;
            to.Show();
            this.Hide();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //to -> <-
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
            cmbBranch.Text = dataGridView2.Rows[chosen].Cells[3].Value.ToString();
            cmbDoctor.Text = dataGridView2.Rows[chosen].Cells[4].Value.ToString();

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {   //make an appointment
            SqlCommand command = new SqlCommand("Update Tbl_Appointments set AppStatus=1,PatientTC=@p3,PatientComplaint=@p1 where Appid=@p2", apply.connection());
            command.Parameters.AddWithValue("@p1", rtxtComplaint.Text);
            command.Parameters.AddWithValue("@p2", txtid.Text);
            command.Parameters.AddWithValue("@p3", LblTC.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Appointment has been done..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
