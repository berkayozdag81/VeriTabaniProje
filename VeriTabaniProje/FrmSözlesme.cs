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
    public partial class FrmSözlesme : Form
    {
        public FrmSözlesme()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432;Database=Arac-Kiralama-Satis; user ID =postgres; password=b.123;");
        string aracId;
        private void aracGetirBtn_Click(object sender, EventArgs e)
        {
            string sorgu1 = "SELECT \"Arac\".\"aracId\", \"Marka\".\"markaAd\", \"Model\".\"Model\",\"Renk\".\"renkAd\",\"Arac\".\"aracKm\",\"Arac\".\"aracFiyat\" ,\"Vites-Turu\".\"vitesAd\",\"Yakit-Turu\".\"yakitAd\",\"AracTipi\".\"tip\",\"Arac\".\"aracResim\"  From \"Arac\" inner JOIN \"Marka\" on \"Arac\".\"aracMarkaId\" = \"Marka\".\"markaId\" inner JOIN \"Model\" on \"Arac\".\"aracModelId\" = \"Model\".\"modelId\" inner JOIN \"Renk\" on \"Arac\".\"aracRenkId\" = \"Renk\".\"renkId\" inner JOIN \"Yakit-Turu\" on \"Arac\".\"aracYakitId\" = \"Yakit-Turu\".\"yakitId\" inner JOIN \"Vites-Turu\" on \"Arac\".\"aracVitesId\" = \"Vites-Turu\".\"vitesId\" inner JOIN \"AracTipi\" on \"Arac\".\"aracTipId\" = \"AracTipi\".\"tipId\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void musteriGetirBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tc = TCtxt.Text.ToString();
            string sql2 = "SELECT * FROM \"Musteri\" WHERE \"Musteri\".\"Tc\" ILIKE '" + tc + "'" ;
            NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, baglanti);
            NpgsqlDataReader read = cmd2.ExecuteReader();
            while (read.Read())
            {
                müsteriadtxt.Text = read["musteriAd"].ToString();
                müsterisoyadTxt.Text = read["musteriSoyad"].ToString();
                müsteriadresTxt.Text = read["adres"].ToString();
                müsterimailTxt.Text = read["email"].ToString();
            }
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string aracTur = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            string aracMarka = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string aracModel = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string aracKm = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string aracRenk = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string aracVites = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            string aracYakit = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            string aracFiyat = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            string resim = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            aracId = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            kmTxt.Text = aracKm;
            vitesTxt.Text = aracVites;
            renkTxr.Text = aracRenk;
            modelTxt.Text = aracModel;
            markaTxt.Text = aracMarka;
            turTxt.Text = aracTur;
            aracFiyatTxt.Text = aracFiyat;
            yakitTxt.Text = aracYakit;
            pictureBox1.ImageLocation = resim;
        }

    

        private void personelGetirBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string personel = personelIdTxt.Text.ToString();
            string sql2 = "SELECT * FROM \"Personel\" WHERE \"Personel\".\"personelTc\" ILIKE '" + personel + "'";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, baglanti);
            NpgsqlDataReader read = cmd2.ExecuteReader();
            while (read.Read())
            {
                personelAdTxt.Text = read["personelAd"].ToString();
                personelSoyadTxt.Text = read["personelSoyad"].ToString();
            }
            baglanti.Close();
        }

        private void satisBtn_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string sözlesmeId = rastgele.Next(1, 100).ToString();
            
            baglanti.Open();
            string kayit = "INSERT INTO \"public\".\"Sözlesme\"( \"aracMarka\",\"aracModel\",\"aracKm\",\"alınacakTutar\",\"müsteriAd\",\"müsteriSoyad\",\"müsteriTc\",\"müsteriMail\",\"müsteriAdres\",\"personelAd\",\"personelSoyad\",\"sözlesmeTarihi\",\"ödemeTipi\",\"sözlesmeId\")VALUES(@aracMarka,@aracModel,@aracKm,@aracFiyat,@müsteriAd,@müsteriSoyad,@müsteriTc,@müsteriMail,@müsteriAdres,@personelAd,@personelSoyad,@sözlesmeTarihi,@ödemeTipi,@sözlesmeId);";
            NpgsqlCommand cmd = new NpgsqlCommand(kayit, baglanti);
            cmd.Parameters.AddWithValue("@aracMarka", markaTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@aracModel", modelTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@aracRenk", renkTxr.Text.ToString());
            cmd.Parameters.AddWithValue("@aracKm", kmTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@aracFiyat",Convert.ToInt64(aracFiyatTxt.Text));
            cmd.Parameters.AddWithValue("@müsteriAd", müsteriadtxt.Text.ToString());
            cmd.Parameters.AddWithValue("@müsteriSoyad", müsterisoyadTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@müsteriTc", TCtxt.Text.ToString());
            cmd.Parameters.AddWithValue("@müsteriMail",müsterimailTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@müsteriAdres", müsteriadresTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@personelAd", personelAdTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@personelSoyad", personelSoyadTxt.Text.ToString());
            cmd.Parameters.AddWithValue("@sözlesmeTarihi", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@ödemeTipi", odemeComboBox.Text.ToString());
            cmd.Parameters.AddWithValue("@sözlesmeId",sözlesmeId);
            cmd.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            string kayitYeni = "INSERT INTO \"public\".\"Arac_Satis\"( \"kazanilanToplamPara\",\"sözlesmeId\")VALUES(@kazanilan,@sözlesmeId)";
            NpgsqlCommand cmdYeni = new NpgsqlCommand(kayitYeni, baglanti);
            cmdYeni.Parameters.AddWithValue("@kazanilan",Convert.ToInt64(aracFiyatTxt.Text));
            cmdYeni.Parameters.AddWithValue("@sözlesmeId", sözlesmeId);
            cmdYeni.ExecuteNonQuery();
            baglanti.Close();


            baglanti.Open();
            string YeniSorgu = "INSERT INTO \"public\".\"Fatura\"( \"faturaKesimTarihi\",\"faturaTutari\",\"faturaKesen\",\"faturaKesilen\")VALUES(@tarih,@para,@personel,@müsteri)";
            NpgsqlCommand Yeni = new NpgsqlCommand(YeniSorgu, baglanti);
            Yeni.Parameters.AddWithValue("@tarih", dateTimePicker1.Text.ToString());
            Yeni.Parameters.AddWithValue("@para", Convert.ToInt64(aracFiyatTxt.Text));
            Yeni.Parameters.AddWithValue("@personel", personelAdTxt.Text.ToString()+personelSoyadTxt.Text.ToString());
            Yeni.Parameters.AddWithValue("@müsteri", müsteriadtxt.Text.ToString()+müsterisoyadTxt.Text.ToString());
            Yeni.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sözleşme Yapıldı!");
        }

        private void FrmSözlesme_Load(object sender, EventArgs e)
        {

        }
    }
}
