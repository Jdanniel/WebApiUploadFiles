﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdTipoPlazaClienteCp
    {
        public int IdTipoPlazaClienteCp { get; set; }
        public int? IdTipoPlazaCliente { get; set; }
        public string Cp { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
