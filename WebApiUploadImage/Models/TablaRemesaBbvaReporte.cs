using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TablaRemesaBbvaReporte
{
    public int? Ticket { get; set; }

    public int? Afiliacion { get; set; }

    public string NoSerie { get; set; }

    public string Remesa { get; set; }

    public string Estatus { get; set; }

    public DateTime? Fecha { get; set; }
}
