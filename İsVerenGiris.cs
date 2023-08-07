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

namespace KariyerNet
{
    public partial class İsVerenGiris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public İsVerenGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-52T0964;Initial Catalog=KariyerNet;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from İsVerenBilgi where kullaniciadi = '" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
             //   MessageBox.Show("Tebrikler Giriş Başarılı"); 
                IsVerenSayfasi gecis = new IsVerenSayfasi();
                gecis.Show();
                this.Hide();
                // ProfilSayfasi gecis = new ProfilSayfasi();
                //gecis.Show();
                //this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            con.Close();
        }

        private void İsVerenGiris_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }
    }
}
