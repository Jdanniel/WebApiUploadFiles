﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdChangeMassiveStatus
    {
        public int IdChangeMassiveStatus { get; set; }
        public int? IdCarga { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdStatus { get; set; }
        public string NoSerie { get; set; }
        public string Errores { get; set; }
        public int? IsProcesado { get; set; }
    }
}
