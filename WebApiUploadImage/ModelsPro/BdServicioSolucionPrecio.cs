﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdServicioSolucionPrecio
    {
        public int IdServicioSolucionPrecio { get; set; }
        public int? IdCliente { get; set; }
        public int? IdServicio { get; set; }
        public int? IdEspecifTipoFalla { get; set; }
        public decimal? Precio { get; set; }
    }
}
