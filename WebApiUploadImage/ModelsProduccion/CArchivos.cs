﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class CArchivos
    {
        public int IdArchivo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string NombreArchivo { get; set; }
        public string DescArchivo { get; set; }
        public int? IsCerradoExito { get; set; }
        public string Status { get; set; }
        public int? IsEnvio { get; set; }
        public int? IsRecepcion { get; set; }
        public int? IsAlmacenMasivo { get; set; }
    }
}
