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

namespace eOkulProjesi
{
    public partial class Frm_OgrenciNotlar : Form
    {
        public Frm_OgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DEVELOPER\SQLEXPRESS;Initial Catalog=eOkul;Integrated Security=True");
        public string numara;
        private void Frm_OgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd,Ogrid,Sinav1,Sinav2,Sinav3,Proje,Ortalama from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.Dersid = Tbl_Dersler.Dersid where Ogrid =@p1", baglanti);
 
            komut.Parameters.AddWithValue("@p1", numara);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Ograd,OgrSoyad from Tbl_Ogrenciler where Ogrid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0]+" "+dr[1];
            }
            baglanti.Close();

        }
    }
}
