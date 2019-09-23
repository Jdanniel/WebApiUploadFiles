﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdControlInsumos
    {
        public int IdBdControlInsumos { get; set; }
        public int? IdCliente { get; set; }
        public int? IdInsumo { get; set; }
        public int? Entrada { get; set; }
        public int? Salida { get; set; }
        public int? Total { get; set; }
        public string NoTarima { get; set; }
        public string PosicionInventario { get; set; }
        public int? IdTipoResponsable { get; set; }
        public int? IdResponsable { get; set; }
        public int? IdStatusInsumo { get; set; }
    }
}
