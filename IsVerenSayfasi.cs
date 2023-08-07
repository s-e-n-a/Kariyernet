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
using DevExpress.Utils.FormShadow;

namespace KariyerNet
{
    public partial class IsVerenSayfasi : Form
    {
        public IsVerenSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public string sqlSorgu;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                //mesleğe göre arama
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
                baglanti.Open();
                DataTable tbl=new DataTable();

                SqlDataAdapter ara =new SqlDataAdapter("Select * from OzgecmisBilgi where meslek like '%" + textBox1.Text + "%'", baglanti);
                ara.Fill(tbl);  
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }

            else if (radioButton2.Checked)
            {
                //sehire göre arama
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
                baglanti.Open();
                DataTable tbl = new DataTable();

                SqlDataAdapter ara = new SqlDataAdapter("Select * from OzgecmisBilgi where sehir like '%" + textBox1.Text + "%'", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }

            else if(radioButton3.Checked)
            {
                //özet bilgiye göre arama
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
                baglanti.Open();
                DataTable tbl = new DataTable();

                SqlDataAdapter ara = new SqlDataAdapter("Select * from OzgecmisBilgi where OzetBilgi like '%" + textBox1.Text + "%'", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }

            else if( radioButton4.Checked)
            {
                //iş deneyimine göre arama 
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
                baglanti.Open();
                DataTable tbl = new DataTable();

                SqlDataAdapter ara = new SqlDataAdapter("Select * from OzgecmisBilgi where IsDeneyimi like '%" + textBox1.Text + "%'", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }

            else if (radioButton5.Checked)
            {
                //bilgisayar bilgisine göre arama
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
                baglanti.Open();
                DataTable tbl = new DataTable();

                SqlDataAdapter ara = new SqlDataAdapter("Select * from OzgecmisBilgi where BilgisayarBilgisi like '%" + textBox1.Text + "%'", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
            else if(radioButton6.Checked)
                    {
                //sertifika bilgisine göre arama
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
                baglanti.Open();
                DataTable tbl = new DataTable();

                SqlDataAdapter ara = new SqlDataAdapter("Select * from OzgecmisBilgi where SertifikaBilgileri like '%" + textBox1.Text + "%'", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }

        
    }
}
