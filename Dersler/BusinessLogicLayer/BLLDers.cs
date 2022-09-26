using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBsvrForm p)
        {
            if( p.BSVROGRID != null && p.BSVRDERSID != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
