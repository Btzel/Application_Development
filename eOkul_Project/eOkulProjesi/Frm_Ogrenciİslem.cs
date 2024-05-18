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
    public partial class Frm_Ogrenciİslem : Form
    {
        public Frm_Ogrenciİslem()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DEVELOPER\SQLEXPRESS;Initial Catalog=eOkul;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string c = "";
            if (radiokiz.Checked == true)
            {
                c = "Kız";
            }
            if (radioerkek.Checked == true)
            {
                c = "Erkek";
            }
            ds.OgrenciEkle(txtAd.Text, txtsoyad.Text, byte.Parse(comboBox1.Text), c);
            MessageBox.Show("Ogrenci Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(txtid.Text);
            ds.OgrenciSil(a);
            MessageBox.Show("Ogrenci Sİlindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string degisken = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (degisken == "Kız")
            {
                radiokiz.Checked = true;
            }
            if (degisken == "Erkek")
            {
                radioerkek.Checked = true;
            }
        }

        private void Frm_Ogrenciİslem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DersAd";
            comboBox1.ValueMember = "Dersid";
            comboBox1.DataSource = dt;
            baglanti.Close();

            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string cinsiyet = "";
            if(radioerkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            if (radiokiz.Checked == true)
            {
                cinsiyet = "Kız";
            }
            int id = Convert.ToInt16(txtid.Text);
            ds.OgrUpdate(txtAd.Text, txtsoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), cinsiyet, id);
            baglanti.Close();
            MessageBox.Show("Ogrenci Guncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtid.Text);
            dataGridView1.DataSource = ds.OgrAra(a);

            

        }
    }
}
