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
    public partial class AracEkle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432;Database=Arac-Kiralama-Satis; user ID =postgres; password=b.123;");
        string markaId, renkId, vitesId, yakitId,  modelId, tipId;
        string aracKm;
        string aracFiyat;

        private void renkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string renkAdı = renkComboBox.Text;
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select \"Renk\".\"renkId\" from \"Renk\" where \"Renk\".\"renkAd\"= '" + renkAdı + "'", baglanti);
            NpgsqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                renkId = oku[0].ToString();
            }
            baglanti.Close();
        }

        private void yakitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yakitAdı = yakitComboBox.Text;
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select \"Yakit-Turu\".\"yakitId\" from \"Yakit-Turu\" where \"Yakit-Turu\".\"yakitAd\"= '" + yakitAdı + "'", baglanti);
            NpgsqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                yakitId = oku[0].ToString();
            }
            baglanti.Close();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {      

            string modelAdı = modelComboBox.Text;
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select \"Model\".\"modelId\" from \"Model\" where \"Model\".\"Model\"= '" + modelAdı + "'", baglanti);
            NpgsqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                modelId = oku[0].ToString();
            }
            baglanti.Close();

        }

        private void kmTxt_TextChanged(object sender, EventArgs e)
        {
            aracKm = kmTxt.Text.ToString();
        }

        private void aracIptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void aracResimBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {

        }

        private void fiyatTxt_TextChanged(object sender, EventArgs e)
        {
            aracFiyat = fiyatTxt.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls) if (item is ComboBox)
                    item.Text = "";
            foreach (Control item2 in Controls) if (item2 is TextBox)
                    item2.Text = "";
            foreach (Control item3 in Controls) if (item3 is PictureBox)
                    item3.Text = "";
        }

        private void vitesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vitesAdı = vitesComboBox.Text;
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select \"Vites-Turu\".\"vitesId\" from \"Vites-Turu\" where \"Vites-Turu\".\"vitesAd\"= '" + vitesAdı + "'", baglanti);
            NpgsqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                vitesId = oku[0].ToString();
            }
            baglanti.Close();
        }

        private void aracTurComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turAdı = aracTurComboBox.Text;
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select \"AracTipi\".\"tipId\" from \"AracTipi\" where \"AracTipi\".\"tip\"= '" + turAdı + "'", baglanti);
            NpgsqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                tipId = oku[0].ToString();
            }
            baglanti.Close();
        }

        public AracEkle()
        {
            InitializeComponent();
        }


        private void markaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                modelComboBox.Items.Clear();
                if (markaComboBox.SelectedIndex == 0)
                {
                    modelComboBox.Items.Add("FOCUS");
                    modelComboBox.Items.Add("MONDEO");
                    modelComboBox.Items.Add("FİESTA");
                    modelComboBox.Items.Add("KUGA");
                }
                else if (markaComboBox.SelectedIndex == 1)
                {
                    modelComboBox.Items.Add("C180");
                    modelComboBox.Items.Add("C200");
                }
                else if (markaComboBox.SelectedIndex == 2)
                {
                    modelComboBox.Items.Add("320");
                    modelComboBox.Items.Add("520");
                }
                else if (markaComboBox.SelectedIndex == 3)
                {
                    modelComboBox.Items.Add("CITY");
                    modelComboBox.Items.Add("CIVIC");
                }
                else if (markaComboBox.SelectedIndex == 4)
                {
                    modelComboBox.Items.Add("MEGANE");
                    modelComboBox.Items.Add("CLIO");
                }
                else if (markaComboBox.SelectedIndex == 5)
                {
                    modelComboBox.Items.Add("ASTRA");
                    modelComboBox.Items.Add("VECTRA");
                    modelComboBox.Items.Add("INSIGNIA");
                    modelComboBox.Items.Add("CORSA");
                }

            }
            catch
            {

                throw;
            }
            string markaAdı = markaComboBox.Text;

            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select \"Marka\".\"markaId\" from \"Marka\" where \"Marka\".\"markaAd\"= '"+markaAdı+"'", baglanti);
            NpgsqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                markaId = oku[0].ToString();
            }
            baglanti.Close();
        }
        private void aracEkleBtn_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string kayit = "INSERT INTO \"public\".\"Arac\"( \"aracMarkaId\",\"aracModelId\", \"aracRenkId\",\"aracKm\", \"aracVitesId\",\"aracYakitId\",\"aracResim\",\"aracTipId\",\"aracFiyat\")VALUES(@aracMarka,@aracModel, @aracRenk,@aracKm, @vitesTuru, @yakitTuru,@aracResim, @aracTur,@aracFiyat);";
            NpgsqlCommand cmd = new NpgsqlCommand(kayit, baglanti);
            cmd.Parameters.AddWithValue("@aracMarka", Convert.ToInt32(markaId));
            cmd.Parameters.AddWithValue("@aracModel", Convert.ToInt32(modelId));
            cmd.Parameters.AddWithValue("@aracRenk", Convert.ToInt32(renkId));
            cmd.Parameters.AddWithValue("@aracKm", aracKm);
            cmd.Parameters.AddWithValue("@vitesTuru", Convert.ToInt32(vitesId));
            cmd.Parameters.AddWithValue("@yakitTuru", Convert.ToInt32(yakitId));
            cmd.Parameters.AddWithValue("@aracResim", pictureBox1.ImageLocation);
            cmd.Parameters.AddWithValue("@aracTur", Convert.ToInt32(tipId));
            cmd.Parameters.AddWithValue("@aracFiyat", Convert.ToDouble(aracFiyat));
            cmd.ExecuteNonQuery();
            baglanti.Close();           
            MessageBox.Show("Araç eklendi");

            foreach (Control item in Controls) if (item is ComboBox)
                    item.Text = "";
            pictureBox1.ImageLocation = "";
            kmTxt.Text = "";
            fiyatTxt.Text = "";
        }
    }
}
