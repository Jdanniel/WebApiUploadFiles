﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdModeloConectividad
    {
        public int IdModeloConectividad { get; set; }
        public int? IdModelo { get; set; }
        public int? IdConectividad { get; set; }
        public string Status { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
