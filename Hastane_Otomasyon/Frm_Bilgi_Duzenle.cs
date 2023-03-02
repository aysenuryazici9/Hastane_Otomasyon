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
    public partial class Frm_Bilgi_Duzenle : Form
    {
        public Frm_Bilgi_Duzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        Sql_Baglantisi bgl=new Sql_Baglantisi();

        private void Frm_Bilgi_Duzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_HastaBilgi where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutx=new SqlCommand("Update Tbl_HastaBilgi set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",bgl.baglanti());
            komutx.Parameters.AddWithValue("@p1", txtAd.Text);
            komutx.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komutx.Parameters.AddWithValue("@p3", msktelefon.Text);
            komutx.Parameters.AddWithValue("@p4", txtSifre.Text);
            komutx.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komutx.Parameters.AddWithValue("@p6", mskTc.Text);
            komutx.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
