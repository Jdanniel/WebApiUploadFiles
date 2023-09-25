using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdCargaChangeDiagnosticadum
{
    public int IdCarga { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
