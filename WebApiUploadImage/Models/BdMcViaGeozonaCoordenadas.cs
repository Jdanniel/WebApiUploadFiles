﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class BdMcViaGeozonaCoordenadas
    {
        public int IdGeozonaCoordenadas { get; set; }
        public int? IdTecnico { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Orden { get; set; }
    }
}
