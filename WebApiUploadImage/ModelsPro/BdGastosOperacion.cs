﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdGastosOperacion
    {
        public int IdGastosOp { get; set; }
        public int? IdCliente { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? Importe { get; set; }
    }
}
