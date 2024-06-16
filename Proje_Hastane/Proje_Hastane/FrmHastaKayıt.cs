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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }

   
     
        sqlbağlantısı bgl = new sqlbağlantısı();
        private void BtnKayıtYap_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn=bgl.baglanti())
            {
                using ( SqlCommand komut = new SqlCommand(" insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSıfre,HastaCınsıyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", conn))
                {
                    komut.Parameters.AddWithValue("@p1", TxTAd.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", msktc.Text);
                    komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                    komut.Parameters.AddWithValue("@p5", TxTSıfre.Text);
                    komut.Parameters.AddWithValue("@p6", CMBCınsıyet.Text);
                    komut.ExecuteNonQuery();
                }
                conn.Close();   
            }
            MessageBox.Show("Kaydınız gerçekleşmiştir. Şifreniz :" + TxTSıfre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
