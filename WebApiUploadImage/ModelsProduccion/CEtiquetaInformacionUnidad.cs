﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class CEtiquetaInformacionUnidad
    {
        public int IdEtiquetaInformacionUnidad { get; set; }
        public string DescEtiquetaInformacionUnidad { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
