﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdZonaCp
    {
        public int IdZonaCp { get; set; }
        public int IdZona { get; set; }
        public string Cp { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
