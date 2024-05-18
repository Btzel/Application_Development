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
    public partial class Frm_SecretaryDetail : Form
    {
        public Frm_SecretaryDetail()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string tc;
        Cls_SqlConnection apply = new Cls_SqlConnection();

        private void Frm_SecretaryDetail_Load(object sender, EventArgs e)
        {
            //Transfer of information
            Frm_SecretaryLog call = new Frm_SecretaryLog();
            LblTC.Text = tc;
            

            SqlCommand command = new SqlCommand("Select SecretaryNameSurname from Tbl_Secretaries where SecretaryTC=@p1", apply.connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                LblNameSurname.Text = dr[0].ToString();
            }
            apply.connection().Close();

            //Branches
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BranchName From Tbl_Branches", apply.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doctors
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as D_NameSurname,DoctorBranch From Tbl_Doctors", apply.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Appointment Panel
            //^Branches-pull
            SqlCommand command1 = new SqlCommand("Select BranchName from Tbl_Branches", apply.connection());
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBranch.Items.Add(dr1[0]);
            }
            apply.connection().Close();
            
            
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbDoctor.Items.Clear();
            //^doctors-pull
            SqlCommand command2 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where Doctorbranch=@p1", apply.connection());
            command2.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbDoctor.Items.Add(dr2[0] + " " + dr2[1]);
            }
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            //Save Data as Appointments
            SqlCommand command = new SqlCommand("Insert into Tbl_Appointments (AppDate,AppHour,AppBranch,AppDoctor,PatientTC,AppStatus) values (@p1,@p2,@p3,@p4,@p5,@p6)", apply.connection());
            command.Parameters.AddWithValue("@p1",mskDate.Text);
            command.Parameters.AddWithValue("@p2",mskHour.Text);
            command.Parameters.AddWithValue("@p3",cmbBranch.Text);
            command.Parameters.AddWithValue("@p4",cmbDoctor.Text);
            command.Parameters.AddWithValue("@p5", mskPatientTC.Text);
            command.Parameters.AddWithValue("@p6", chkStatus.Checked);


            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Appointment is created..", "Information..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            

        }

        private void btnAnnouncement_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Announcements (Ann) values (@p1)", apply.connection());
            command.Parameters.AddWithValue("@p1", rtxtAnnouncement.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Announcement has been made..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            Frm_SecretaryDPanel to = new Frm_SecretaryDPanel();
            to.Show();
            
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            Frm_SecretaryBPanel to = new Frm_SecretaryBPanel();
            to.Show();
        }

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            Frm_SecretaryAPanel to = new Frm_SecretaryAPanel();
            to.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_DoctorAnnouncements to = new Frm_DoctorAnnouncements();
            to.Show();
        }
    }
}
