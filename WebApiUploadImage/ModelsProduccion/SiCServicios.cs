﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class SiCServicios
    {
        public int IdServicio { get; set; }
        public string DescServicio { get; set; }
        public int? IdTipoServicio { get; set; }
        public int? IdResponsableTecnico { get; set; }
        public string Status { get; set; }
    }
}
