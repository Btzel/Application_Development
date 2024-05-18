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
    public partial class Frm_DoctorDetail : Form
    {
        public Frm_DoctorDetail()
        {
            InitializeComponent();
        }
        public string tc3;
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void Frm_DoctorDetail_Load(object sender, EventArgs e)
        {   //pull-info-doctor
            LblTC.Text = tc3;
            SqlCommand command = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorTC='" + tc3 + "'", apply.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }

            //pull-Appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where AppDoctor='" + LblNameSurname.Text + "'", apply.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            Frm_DoctorEditInfo to = new Frm_DoctorEditInfo();
            to.tc = LblTC.Text;
            
            to.Show();
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            Frm_DoctorAnnouncements to = new Frm_DoctorAnnouncements();
            to.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            rtxtAppointment.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
