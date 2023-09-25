using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class NoSeriesFaltante
{
    public int IdNoSeriesFaltantes { get; set; }

    public string NoSerie { get; set; }

    public int? SinInstalacionRetiro { get; set; }
}
