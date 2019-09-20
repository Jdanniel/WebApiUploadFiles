﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdCompromisosCompromiso
    {
        public int IdCompromisosCompromiso { get; set; }
        public int? IdCompromiso { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Status { get; set; }
        public string Compromiso { get; set; }
    }
}
