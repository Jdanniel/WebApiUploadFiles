using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BorrarActualizarUnidad
{
    public string NoSerie { get; set; }

    public DateTime? FechaBitacora { get; set; }

    public int? IsActualizar { get; set; }
}
