using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace pansiyon_uygulaması
{
    public partial class frmYeniMüsteri : Form
    {
        public frmYeniMüsteri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PUBLIRN\\SQLEXPRESS;Initial Catalog=pansiyonKayit;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmYeniMüsteri_Load(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "109";
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar dolu odaları gösterir.");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = buyukTarih - kucukTarih;

            label3.Text = Sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label3.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into musteriEkle (Adi,Soyadi,Cinsiyeti,Telefon,Mail,TC,OdaNo,Ucret) values('"+txtAdi.Text+"','"+txtSoyadi.Text+"','"+comboBox1.Text+"','"+txtTel.Text+"','"+txtMail.Text+"','"+txtOdaNumarası.Text+"','"+txtUcret.Text+"')",con);
            komut.ExecuteNonQuery();//gönderilen komut üzerinde değişiklikler yapıyor.
            con.Close();
            MessageBox.Show("Müşteri Kaydı yapıldı.");
        }
    }
    
}
