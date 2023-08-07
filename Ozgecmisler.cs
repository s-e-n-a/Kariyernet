using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace KariyerNet
{
    public partial class Ozgecmisler : Form
    {

      
        public Ozgecmisler()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
  
        void verioku()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");

            SqlCommand komut = new SqlCommand("Select * from IllerBilgi", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["il"]);
            }
            baglanti.Close();




            SqlCommand komut2 = new SqlCommand("Select * from UniversiteBilgi", baglanti);
            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                comboBox13.Items.Add(dr2["universiteadi"]);
            }
            baglanti.Close();



            SqlCommand komut3 = new SqlCommand("Select * from FakulteBilgi", baglanti);
            SqlDataReader dr3;
            baglanti.Open();
            dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                comboBox15.Items.Add(dr3["fakulteadi"]);
            }
            baglanti.Close();




            SqlCommand komut4 = new SqlCommand("Select * from BolumBilgi", baglanti);
            SqlDataReader dr4;
            baglanti.Open();
            dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                comboBox17.Items.Add(dr4["bolumadi"]);
            }
            baglanti.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                string isim = textBox1.Text;
                string soyisim = textBox2.Text;
                string meslek = textBox3.Text;
                string medenidurum;
                string sehir = comboBox1.SelectedItem.ToString();
                string ilce = comboBox10.SelectedItem.ToString();
                string dogumtarihi = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Tarih formatını düzeltme
                string EPostaAdresi = textBox4.Text;
                string TelefonNumarasi = textBox5.Text;
                string Adres = textBox6.Text;
                string PostaKodu = textBox7.Text;
                string OzetBilgi = textBox9.Text;
                string lise = textBox15.Text;
                string universite = comboBox13.SelectedItem.ToString();
                string fakulte = comboBox15.SelectedItem.ToString();
                string bolum = comboBox17.SelectedItem.ToString();
                string ogrenimtipi = comboBox18.SelectedItem.ToString();
                string isdeneyimi = textBox8.Text;
                string yabancidil = textBox10.Text;
                string bilgisayarbilgisi = textBox11.Text;
                string sertifikabilgileri = textBox12.Text;
                string hobilerveilgialanlari = textBox13.Text;
                string referanslar = textBox14.Text;

                if (radioButton1.Checked == true)
                {
                    medenidurum = "Evli";
                }
                else
                {
                    medenidurum = "Bekar";
                }

                string connectionString = "Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True";

                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();

                    string komut =
                        "INSERT INTO OzgecmisBilgi (isim, soyisim, meslek, medenidurum, sehir, ilce, dogumtarihi, EPostaAdresi, TelefonNumarasi, Adres, PostaKodu, OzetBilgi, Lise, Universite, Fakulte, Bolum, OgrenimTipi, IsDeneyimi, YabanciDil, BilgisayarBilgisi, SertifikaBilgileri, HobilerVeIlgiAlanlari, Referanslar) " +
                        "VALUES (@isim, @soyisim, @meslek, @medenidurum, @sehir, @ilce, @dogumtarihi, @EPostaAdresi, @TelefonNumarasi, @Adres, @PostaKodu, @OzetBilgi, @Lise, @Universite, @Fakulte, @Bolum, @OgrenimTipi, @IsDeneyimi, @YabanciDil, @BilgisayarBilgisi, @SertifikaBilgileri, @HobilerVeIlgiAlanlari, @Referanslar)";

                    using (SqlCommand sorgu = new SqlCommand(komut, baglanti))
                    {
                        sorgu.Parameters.AddWithValue("@isim", isim);
                        sorgu.Parameters.AddWithValue("@soyisim", soyisim);
                        sorgu.Parameters.AddWithValue("@meslek", meslek);
                        sorgu.Parameters.AddWithValue("@medenidurum", medenidurum);
                        sorgu.Parameters.AddWithValue("@sehir", sehir);
                        sorgu.Parameters.AddWithValue("@ilce", ilce);
                        sorgu.Parameters.AddWithValue("@dogumtarihi", dogumtarihi);
                        sorgu.Parameters.AddWithValue("@EPostaAdresi", EPostaAdresi);
                        sorgu.Parameters.AddWithValue("@TelefonNumarasi", TelefonNumarasi);
                        sorgu.Parameters.AddWithValue("@Adres", Adres);
                        sorgu.Parameters.AddWithValue("@PostaKodu", PostaKodu);
                        sorgu.Parameters.AddWithValue("@OzetBilgi", OzetBilgi);
                        sorgu.Parameters.AddWithValue("@Lise", lise);
                        sorgu.Parameters.AddWithValue("@Universite", universite);
                        sorgu.Parameters.AddWithValue("@Fakulte", fakulte);
                        sorgu.Parameters.AddWithValue("@Bolum", bolum);
                        sorgu.Parameters.AddWithValue("@OgrenimTipi", ogrenimtipi);
                        sorgu.Parameters.AddWithValue("@IsDeneyimi", isdeneyimi);
                        sorgu.Parameters.AddWithValue("@YabanciDil", yabancidil);
                        sorgu.Parameters.AddWithValue("@BilgisayarBilgisi", bilgisayarbilgisi);
                        sorgu.Parameters.AddWithValue("@SertifikaBilgileri", sertifikabilgileri);
                        sorgu.Parameters.AddWithValue("@HobilerVeIlgiAlanlari", hobilerveilgialanlari);
                        sorgu.Parameters.AddWithValue("@Referanslar", referanslar);

                        sorgu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Eklendi");
                    
                }
            }

        }

        private void Ozgecmisler_Load(object sender, EventArgs e)
        {
            verioku();
         }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select ilce from IlceBilgi where ilid=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex+1);
            SqlDataReader dr1;

            dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                comboBox10.Items.Add(dr1["ilce"]);
            }
            baglanti.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
