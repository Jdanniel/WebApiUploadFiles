using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CostoRefMicrosip
{
    public int Id { get; set; }

    public string Sku { get; set; }

    public string Descripcion { get; set; }

    public DateTime? FechaUCompra { get; set; }

    public double? CostoUCompra { get; set; }
}
