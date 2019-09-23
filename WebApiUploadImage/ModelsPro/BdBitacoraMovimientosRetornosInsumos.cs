﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdBitacoraMovimientosRetornosInsumos
    {
        public int IdBitacoraMri { get; set; }
        public int IdInsumo { get; set; }
        public int Entrada { get; set; }
        public int IdCliente { get; set; }
        public int? IdEnvio { get; set; }
        public int? IdTipoResponsableOrigen { get; set; }
        public int? IdResponsableOrigen { get; set; }
        public int? IdTipoResponsableDestino { get; set; }
        public int? IdResponsableDestino { get; set; }
        public int? IdStatusInsumo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string IdConsolidado { get; set; }
    }
}
