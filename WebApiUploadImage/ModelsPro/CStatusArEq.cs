﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CStatusArEq
    {
        public int IdStatusArEq { get; set; }
        public string DescStatusArEq { get; set; }
        public int? IdStatusAr { get; set; }
        public int? IdCliente { get; set; }

        public virtual CStatusAr IdStatusArNavigation { get; set; }
    }
}
