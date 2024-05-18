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
    public partial class Frm_SinavNotlari : Form
    {
        public Frm_SinavNotlari()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DEVELOPER\SQLEXPRESS;Initial Catalog=eOkul;Integrated Security=True");
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtid.Text));
            
        }

        private void Frm_SinavNotlari_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KulupAd";
            comboBox1.ValueMember = "Kulupid";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtS1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtS2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtS3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        int s1, s2, s3, proje;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            ds.OgrUpdate(byte.Parse(txtS1.Text), byte.Parse(txtS2.Text), byte.Parse(txtS3.Text), byte.Parse(txtProje.Text), int.Parse(txtid.Text) , byte.Parse(comboBox1.Text));
            MessageBox.Show("Bilgiler Guncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            comboBox1.Text = "";
            txtS1.Text = "";
            txtS2.Text = "";
            txtS3.Text = "";
            txtOrtalama.Text = "";
            txtProje.Text = "";
            txtDurum.Text = "";
            txtid.Focus();
        }

        decimal ortalama;
        Boolean durum;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(txtS1.Text);
            s2 = Convert.ToInt32(txtS2.Text);
            s3 = Convert.ToInt32(txtS3.Text);
            proje = Convert.ToInt32(txtProje.Text);
            ortalama = (s1 + s2 + s3 + proje) / 4;
            
            if (ortalama > 49)
            {
                durum = true;
            }
            else
            {
                durum = false;
            }
            ds.OgrHesapla(ortalama,durum,int.Parse(txtid.Text),byte.Parse(comboBox1.Text));
            MessageBox.Show("Not Hesaplandı..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
