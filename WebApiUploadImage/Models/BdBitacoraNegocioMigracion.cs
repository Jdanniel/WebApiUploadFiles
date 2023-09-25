using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraNegocioMigracion
{
    public int IdBitacoraNegocioMigracion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
