﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class BdBitacoraValidacionPrefacturacion
    {
        public int IdBitacoraValidacionPrefacturacion { get; set; }
        public int? IdAr { get; set; }
        public int? IdStatusIni { get; set; }
        public int? IdStatusFin { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Documento { get; set; }
        public string Comentario { get; set; }
    }
}
