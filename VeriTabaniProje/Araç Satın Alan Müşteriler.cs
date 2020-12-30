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
    public partial class Müşteriler : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432;Database=Arac-Kiralama-Satis; user ID =postgres; password=b.123;");

        public Müşteriler()
        {
            InitializeComponent();
        }
        private void ListeBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"Musteri\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tc = silinenMüsteriTcTxt.Text.ToString();
            string sql1 = "CALL müsteriSil('" +tc +"')";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, baglanti);
            cmd1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri silindi.");

            string sorgu = "select * from \"Musteri\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            silinenMüsteriTcTxt.Text = "";
        }
        private void araBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tc = arananTxt.Text.ToString();
            string sql2 = "SELECT * FROM musteriara('" + tc + "')";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql2, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            cmd2.ExecuteNonQuery();
            baglanti.Close();

            arananTxt.Text = "";
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string müsteriTc = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string müsteriAd = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string müsteriSoyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string müsteriAdres = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string müsteriMail = dataGridView1.Rows[secilen].Cells[1].Value.ToString();


            TCtxt.Text = müsteriTc;
            adtxt.Text = müsteriAd;
            soyadTxt.Text = müsteriSoyad;
            adresTxt.Text = müsteriAdres;
            mailTxt.Text = müsteriMail;

        }

        private void güncelBtn_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            string sorgu = "UPDATE \"Musteri\" SET \"musteriAd\" = '"+adtxt.Text.ToString()+ "' ,\"musteriSoyad\" = '" + soyadTxt.Text.ToString() + "',\"adres\" = '" + adresTxt.Text.ToString() + "',\"email\" = '" + mailTxt.Text.ToString() + "' WHERE  \"Tc\" = '" + TCtxt.Text.ToString() + "'";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            cmd2.ExecuteNonQuery();         
            baglanti.Close();


            MessageBox.Show("Güncelleme işlemi tamamlandı.");

         
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {

        }
    }
}
