using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class Temporal2
{
    public int IdCliente { get; set; }

    public string DescRegion { get; set; }

    public int? EnTiempo { get; set; }

    public int? FueraDeTiempo { get; set; }
}
