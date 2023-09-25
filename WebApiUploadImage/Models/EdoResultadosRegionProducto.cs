﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class EdoResultadosRegionProducto
{
    public int Id { get; set; }

    public string Producto { get; set; }

    public string Concepto { get; set; }

    public double? Bajio { get; set; }

    public double? Centro { get; set; }

    public double? Chihuahua { get; set; }

    public double? Noroeste { get; set; }

    public double? Norte { get; set; }

    public double? Pacifico { get; set; }

    public double? Sureste { get; set; }

    public double? Sur { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string Tipo { get; set; }

    public int? Orden { get; set; }

    public int? TipoConcepto { get; set; }
}
