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
    public partial class Frm_SecretaryDPanel : Form
    {
        public Frm_SecretaryDPanel()
        {
            InitializeComponent();
        }
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void Frm_SecretaryDPanel_Load(object sender, EventArgs e)
        {   
            //doctor-pull
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doctors", apply.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //Branch-pull-cmb
            SqlCommand command = new SqlCommand("Select BranchName from Tbl_Branches", apply.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbBranch.Items.Add(dr[0]);
            }
            

            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add
            SqlCommand command = new SqlCommand("Insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorBranch,DoctorTC,DoctorPassword) values (@p1,@p2,@p3,@p4,@p5)", apply.connection());
            command.Parameters.AddWithValue("@p1",txtName.Text);
            command.Parameters.AddWithValue("@p2",txtSurname.Text);
            command.Parameters.AddWithValue("@p3",cmbBranch.Text);
            command.Parameters.AddWithValue("@p4",mskTC.Text);
            command.Parameters.AddWithValue("@p5",txtPassword.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Doctor is added..");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete
            SqlCommand command = new SqlCommand("Delete From Tbl_Doctors where DoctorTC=@p1", apply.connection());
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Doctor is deleted..");
        }

     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //To-> <-
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p4 where DoctorTC=@p5", apply.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbBranch.Text);
            command.Parameters.AddWithValue("@p4", txtPassword.Text);
            command.Parameters.AddWithValue("@p5", mskTC.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Doctor is updated..");
        }
    }
}
