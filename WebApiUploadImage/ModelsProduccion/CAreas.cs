﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class CAreas
    {
        public int IdArea { get; set; }
        public string DescArea { get; set; }
        public int? IdJefeArea { get; set; }
        public string Status { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
