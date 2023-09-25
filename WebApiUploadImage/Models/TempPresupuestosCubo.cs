﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TempPresupuestosCubo
{
    public string Tipo { get; set; }

    public int? Year { get; set; }

    public int? IdCliente { get; set; }

    public decimal? VentasBrutas { get; set; }

    public decimal? Penalizaciones { get; set; }

    public decimal? VentasNetas { get; set; }

    public decimal? ManoObra { get; set; }

    public decimal? GastosIndirectos { get; set; }

    public decimal? Refacciones { get; set; }

    public decimal? CostoTotal { get; set; }

    public decimal? MargenContribucion { get; set; }

    public decimal? GastosOperacion { get; set; }

    public decimal? Utilidad { get; set; }
}
