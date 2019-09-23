﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CReparaciones
    {
        public int IdReparacion { get; set; }
        public int IdCliente { get; set; }
        public string DescReparacion { get; set; }
        public decimal? Precio { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
