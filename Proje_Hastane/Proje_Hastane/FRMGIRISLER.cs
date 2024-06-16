using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FRMGIRISLER : Form
    {
        public FRMGIRISLER()
        {
            InitializeComponent();
        }


        private void BtnHastaGirişi_Click(object sender, EventArgs e)
        {
            HastaGırıs fr = new HastaGırıs();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktorGirişi_Click(object sender, EventArgs e)
        {
            FrmDoktorGırıs fr = new FrmDoktorGırıs();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirişi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş fr =new FrmSekreterGiriş();
            fr.Show();
            this.Hide();
        }
    }
}
