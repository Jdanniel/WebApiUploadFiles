using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdReporteTipoUsuario
{
    public int IdReporteTipoUsuarios { get; set; }

    public int? IdUsuario { get; set; }

    public string Menu { get; set; }

    public string TipoUsuarios { get; set; }

    public int? IdTipoUsuario { get; set; }
}
