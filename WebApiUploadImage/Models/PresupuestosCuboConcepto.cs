using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class PresupuestosCuboConcepto
{
    public int? Year { get; set; }

    public int? IdCliente { get; set; }

    public int? IdRegion { get; set; }

    public int? IdConcepto { get; set; }

    public string Tipo { get; set; }

    public decimal? Importe { get; set; }
}
