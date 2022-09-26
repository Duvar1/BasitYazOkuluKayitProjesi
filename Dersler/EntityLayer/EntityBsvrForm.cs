using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBsvrForm
    {
        private int bsvrid;
        private int bsvrdersid;
        private int bsvrogrid;

        public int BSVRID { get => bsvrid; set => bsvrid = value; }
        public int BSVRDERSID { get => bsvrdersid; set => bsvrdersid = value; }
        public int BSVROGRID { get => bsvrogrid; set => bsvrogrid = value; }
    }
}
