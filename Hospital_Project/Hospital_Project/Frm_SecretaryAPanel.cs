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
    public partial class Frm_SecretaryAPanel : Form
    {
        public Frm_SecretaryAPanel()
        {
            InitializeComponent();
        }
        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void Frm_SecretaryAPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments", apply.connection());
            da.Fill(dt);
            dataGridView11.DataSource = dt;
        }
        public int chosen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chosen = dataGridView11.SelectedCells[0].RowIndex;
            
            
        }
    }
}
