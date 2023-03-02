using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon
{
    public partial class Frm_Girisislem : Form
    {
        public Frm_Girisislem()
        {
            InitializeComponent();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
             Frm_Hastaislem fr = new Frm_Hastaislem();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            Frm_Doktor_Giris fr=new Frm_Doktor_Giris();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGiri_Click(object sender, EventArgs e)
        {
            Frm_SekreterGiris fr = new Frm_SekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void Frm_Girisislem_Load(object sender, EventArgs e)
        {

        }
    }
}
