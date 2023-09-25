using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class HistoricoBbva
{
    public int IdHistorico { get; set; }

    public string NoSerieSale { get; set; }

    public DateTime? FechaActualizacion { get; set; }
}
