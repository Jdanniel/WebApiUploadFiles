﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdBitacoraAlmacenStatus
    {
        public int IdBitacora { get; set; }
        public int? IdAlmacen { get; set; }
        public string StatusAnterior { get; set; }
        public string StatusActual { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
