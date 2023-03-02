using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyon
{
    internal class Sql_Baglantisi//sınıf adı
    {
        public SqlConnection baglanti()//metotadı
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-CVNIP36M\\MSSQL;Initial Catalog=Hastane_Proje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
