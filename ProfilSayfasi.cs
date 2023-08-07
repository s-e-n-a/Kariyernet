using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KariyerNet
{
    public partial class ProfilSayfasi : Form
    {
        public ProfilSayfasi()
        {
            InitializeComponent();
        }

        private void ProfilSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ozgecmisler gecis = new Ozgecmisler();
            gecis.Show();
            this.Hide();
        }
    }
}
