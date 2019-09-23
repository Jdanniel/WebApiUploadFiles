﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CMcEstacionEvaluarReglas
    {
        public int IdEstacionEvaluarReglas { get; set; }
        public string DescripcionEstacionReglas { get; set; }
        public int? MinTiempo { get; set; }
        public int? MaxTiempo { get; set; }
        public int? DanadoMinTiempo { get; set; }
        public int? DanadoMaxTiempo { get; set; }
        public int? IdStatusUnidad { get; set; }
        public int? IdProducto { get; set; }
        public int? IdEstacionEvaluar { get; set; }
        public string Regla { get; set; }
    }
}
