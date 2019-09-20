﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdSolicitudesDevolucionUnidad
    {
        public int IdSolicitudDevolucionUnidad { get; set; }
        public int IdSolicitudDevolucion { get; set; }
        public int IdUnidad { get; set; }
        public string NoSerie { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IsRecibidoRetorno { get; set; }
        public int? IdStatusUnidadIni { get; set; }

        public virtual BdUnidades IdUnidadNavigation { get; set; }
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}
