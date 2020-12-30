using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace VeriTabaniProje
{
    public partial class AracListesi : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432;Database=Arac-Kiralama-Satis; user ID =postgres; password=b.123;");
        string aracId;
        public AracListesi()
        {
            InitializeComponent();
        }
        private void aracListeBtn_Click(object sender, EventArgs e)
        {
            string sorgu1 = "SELECT \"Arac\".\"aracId\", \"Marka\".\"markaAd\", \"Model\".\"Model\",\"Renk\".\"renkAd\",\"Arac\".\"aracKm\",\"Arac\".\"aracFiyat\" ,\"Vites-Turu\".\"vitesAd\",\"Yakit-Turu\".\"yakitAd\",\"AracTipi\".\"tip\",\"Arac\".\"aracResim\"  From \"Arac\" inner JOIN \"Marka\" on \"Arac\".\"aracMarkaId\" = \"Marka\".\"markaId\" inner JOIN \"Model\" on \"Arac\".\"aracModelId\" = \"Model\".\"modelId\" inner JOIN \"Renk\" on \"Arac\".\"aracRenkId\" = \"Renk\".\"renkId\" inner JOIN \"Yakit-Turu\" on \"Arac\".\"aracYakitId\" = \"Yakit-Turu\".\"yakitId\" inner JOIN \"Vites-Turu\" on \"Arac\".\"aracVitesId\" = \"Vites-Turu\".\"vitesId\" inner JOIN \"AracTipi\" on \"Arac\".\"aracTipId\" = \"AracTipi\".\"tipId\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string resim = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            string aracTur = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            string model = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string marka = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string renk = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string km = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string yakit = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            string vites = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            string fiyat = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            aracId = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            fiyatTxt.Text = fiyat;
            modelTxt.Text = model;
            markaTxt.Text = marka;
            türTxt.Text = aracTur;
            renkTxt.Text = renk;
            kmTxt.Text = km;
            vitesTxt.Text = vites;
            yakitTxt.Text = yakit;
            pictureBox2.ImageLocation = resim.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            string sorgu = "UPDATE \"Arac\" SET \"aracKm\" = '" + kmTxt.Text.ToString() + "',\"aracFiyat\" = '" + fiyatTxt.Text.ToString() + "' WHERE  \"aracId\" = '" + int.Parse(aracId) + "' ";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi tamamlandı.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aracIptalBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls) if (item is TextBox)
                    item.Text = "";
             
        }

        private void AracListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
