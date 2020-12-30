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
using System.Data.SqlClient;

namespace VeriTabaniProje
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432;Database=Arac-Kiralama-Satis; user ID =postgres; password=b.123;");
       
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void müsteriEkleBtn_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle musteriEkle = new FrmMusteriEkle();
            musteriEkle.ShowDialog();
        }

        private void müsteriListeBtn_Click(object sender, EventArgs e)
        {
            Müşteriler satınAlanlar = new Müşteriler();
            satınAlanlar.ShowDialog();
        }

        private void aracKayitBtn_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.ShowDialog();
        }

        private void aracListeBtn_Click(object sender, EventArgs e)
        {
            AracListesi aracListesi = new AracListesi();
            aracListesi.ShowDialog();
        }

        private void sozlesmeBtn_Click(object sender, EventArgs e)
        {
            FrmSözlesme frmSözlesme = new FrmSözlesme();
            frmSözlesme.ShowDialog();
        }

        private void satisBtn_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            satislar.ShowDialog();
        }
    }
}
