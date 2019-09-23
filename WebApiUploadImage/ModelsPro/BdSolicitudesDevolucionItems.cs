﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdSolicitudesDevolucionItems
    {
        public int IdSolicitudDevolucionItem { get; set; }
        public int IdSolicitudDevolucion { get; set; }
        public int IdTipoItemSolicitudAlmacen { get; set; }
        public string Cantidad { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IsRecibidoRetorno { get; set; }
        public int? IdStatusInsumoIni { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdAccesorio { get; set; }
        public int? IdSparePart { get; set; }
        public int? IdRefaccion { get; set; }
    }
}
