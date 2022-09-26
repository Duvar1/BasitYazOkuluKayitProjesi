using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("Select*From TBL_DERS", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(dr["DERSID"].ToString());
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.MIN = int.Parse(dr["DERSMINKONT"].ToString());
                ent.MAX = int.Parse(dr["DERSMAXKONT"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBsvrForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BSVR (OGRID,DERSID) values (@P1,@P2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", parametre.BSVROGRID);
            komut.Parameters.AddWithValue("@P2", parametre.BSVRDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }

    }
}
