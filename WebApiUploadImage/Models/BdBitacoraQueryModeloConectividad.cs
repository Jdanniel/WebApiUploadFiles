using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraQueryModeloConectividad
{
    public string Query { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
