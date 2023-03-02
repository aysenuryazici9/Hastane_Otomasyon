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
    public partial class FrmDoktorBilgi_Duzenle : Form
    {
        public FrmDoktorBilgi_Duzenle()
        {
            InitializeComponent();
        }
        Sql_Baglantisi bgl=new Sql_Baglantisi();
        public string TCNO;       

        private void FrmDoktorBilgi_Duzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select *From Tbl_DoktorBilgi Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAd.Text = dr[1].ToString();  
                txtSoyad.Text = dr[2].ToString();  
                cmbBrans.Text = dr[3].ToString();  
                txtSifre.Text = dr[5].ToString();  
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_DoktorBilgi set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
