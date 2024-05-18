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
    public partial class Frm_DoctorAnnouncements : Form
    {
        public Frm_DoctorAnnouncements()
        {
            InitializeComponent();
        }


        Cls_SqlConnection apply = new Cls_SqlConnection();
        private void Frm_DoctorAnnouncements_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Announcements", apply.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
