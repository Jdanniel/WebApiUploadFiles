﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class CZonasAgenteCallCenter
    {
        public int IdZonaAgenteCallcenter { get; set; }
        public int IdAgente { get; set; }
        public int IdZona { get; set; }
        public string Status { get; set; }
    }
}
