﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdEnvioInsumos
    {
        public int IdEnvioInsumo { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdEnvio { get; set; }
        public int? Cantidad { get; set; }
        public int? IdTipoResponsable { get; set; }
        public int? IdResponsable { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IsRecibida { get; set; }
        public DateTime? FecRecibida { get; set; }
        public int? IdUsuarioRecepcion { get; set; }
        public int? IdStatusUnidad2 { get; set; }

        public virtual BdEnvios IdEnvioNavigation { get; set; }
    }
}
