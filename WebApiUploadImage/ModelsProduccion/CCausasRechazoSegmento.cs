﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class CCausasRechazoSegmento
    {
        public int IdCausaRechazoSegmento { get; set; }
        public int? IdCliente { get; set; }
        public int? IdSegmento { get; set; }
        public int? IdCausaRechazo { get; set; }
    }
}
