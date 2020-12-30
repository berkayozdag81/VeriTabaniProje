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
    public partial class Satislar : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432;Database=Arac-Kiralama-Satis; user ID =postgres; password=b.123;");

        public Satislar()
        {
            InitializeComponent();
        }

        private void satislarBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"Sözlesme\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kazancBtn_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            toplamKazanTxt.Text = toplam.ToString();
        }

        private void Satislar_Load(object sender, EventArgs e)
        {

        }
    }
}
