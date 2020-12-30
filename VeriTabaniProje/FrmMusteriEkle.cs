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
    public partial class FrmMusteriEkle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432;Database=Arac-Kiralama-Satis; user ID =postgres; password=b.123;");

        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        private void musteriIptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void musteriEkleBtn2_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                string sql1 = "SELECT * FROM musteriKayitEkle('" + adresTxt.Text + "','" + mailTxt.Text + "','" + adtxt.Text + "','" + soyadTxt.Text + "','" + TCtxt.Text + "')";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, baglanti);
                cmd1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri eklendi.");
            
                foreach (Control item in Controls) if (item is TextBox)
                    item.Text = "";
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
