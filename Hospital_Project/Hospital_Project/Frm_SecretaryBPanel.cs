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
    public partial class Frm_SecretaryBPanel : Form
    {
        public Frm_SecretaryBPanel()
        {
            InitializeComponent();
        }
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void Frm_SecretaryBPanel_Load(object sender, EventArgs e)
        {
            //branch-pull
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Branchid,BranchName from Tbl_Branches", apply.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //to-> <-
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add-Branch
            SqlCommand command = new SqlCommand("insert into Tbl_Branches (BranchName) values (@p1)", apply.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Branch is added..","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete-Branch
            SqlCommand command = new SqlCommand("Delete From Tbl_Branches where Branchid=@p1", apply.connection());
            command.Parameters.AddWithValue("@p1", txtid.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Branch is deleted..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Branches set BranchName=@p1 where Branchid=@p2", apply.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtid.Text);
            command.ExecuteNonQuery();
            apply.connection().Close();
            MessageBox.Show("Branch is updated..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
