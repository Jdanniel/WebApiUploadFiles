﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class CTipoArchivo
    {
        public int IdTipoArchivo { get; set; }
        public string DescTipoArchivo { get; set; }
        public string Extension { get; set; }
        public string Imagen { get; set; }
    }
}
