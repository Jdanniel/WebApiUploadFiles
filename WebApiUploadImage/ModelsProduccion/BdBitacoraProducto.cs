﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdBitacoraProducto
    {
        public int IdBitacoraProducto { get; set; }
        public string DescProducto { get; set; }
        public string Status { get; set; }
        public int? IdUsuario { get; set; }
        public int? IsUpdate { get; set; }
    }
}
