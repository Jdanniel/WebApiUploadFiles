using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdEnviosConsolidado
{
    public int IdConsolidado { get; set; }

    public int? Consolidado { get; set; }

    public int? IdSolicitud { get; set; }
}
