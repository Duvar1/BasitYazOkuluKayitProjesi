﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtbrans;

        public int OgrtId { get => ogrtid; set => ogrtid = value; }
        public string OgrtAd { get => ogrtad; set => ogrtad = value; }
        public int OgrtBrans { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
