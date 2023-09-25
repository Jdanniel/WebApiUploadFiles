using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class EnviosRegion
{
    public int Id { get; set; }

    public string Region { get; set; }

    public DateTime? Fecha { get; set; }

    public double? Importe { get; set; }

    public string Proveedor { get; set; }
}
