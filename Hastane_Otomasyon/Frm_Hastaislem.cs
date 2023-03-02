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

namespace Hastane_Otomasyon
{
    public partial class Frm_Hastaislem : Form
    {
        public Frm_Hastaislem()
        {
            InitializeComponent();
        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();

        private void linklbluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_HastaKayit fr=new Frm_HastaKayit(); 
            fr.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *From Tbl_HastaBilgi Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Frm_HastaDetay fr = new Frm_HastaDetay();
                fr.tc = mskTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }

        private void Frm_Hastaislem_Load(object sender, EventArgs e)
        {

        }
    }
}
