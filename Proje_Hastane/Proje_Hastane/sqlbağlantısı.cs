using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Proje_Hastane
{
     class sqlbağlantısı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=YUSUF;Initial Catalog=HastaneDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
