using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BackupBdZonasCp
{
    public string AbreviaturaOrigen { get; set; }

    public string AbreviaturaDestino { get; set; }

    public int? Zona { get; set; }
}
