using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdMasivoReparacion
{
    public int IdMasivoReparacion { get; set; }

    public int? IdCarga { get; set; }

    public string NoSerie { get; set; }

    public string Comentario { get; set; }
}
