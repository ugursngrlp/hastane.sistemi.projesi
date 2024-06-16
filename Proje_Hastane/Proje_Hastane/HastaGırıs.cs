using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    public partial class HastaGırıs : Form
    {

        sqlbağlantısı bgl = new sqlbağlantısı();

        public HastaGırıs()
        {
                InitializeComponent();
        }

        private void LNKUYEOL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
        }

        private void BtnGırısYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1 and HastaSıfre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", TXTSFR.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                 FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc=mskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & ŞİFRE");
            }
            bgl.baglanti().Close();
        }

        private void HastaGırıs_Load(object sender, EventArgs e)
        {

        }
    }

}
