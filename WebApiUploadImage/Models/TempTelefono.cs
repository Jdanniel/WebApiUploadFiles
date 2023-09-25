using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TempTelefono
{
    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string DescNegocio { get; set; }

    public int? IdUsuario { get; set; }
}
