﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class BdComprobacionViaticos2
    {
        public int IdComprobacionViaticos { get; set; }
        public int IdSolicitudViaticos { get; set; }
        public decimal? MontoComprobado { get; set; }
        public string ArchivoPdf { get; set; }
        public string ArchivoXml { get; set; }
        public string Estatus { get; set; }
        public decimal? MontoAprobado { get; set; }
        public int? Status { get; set; }
        public int? IdRazon { get; set; }
        public int? IdTipoViatico { get; set; }
        public int? IdViatico { get; set; }
        public int? IsValidadorXml { get; set; }
        public int? IsAprobado { get; set; }
    }
}
