using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class Tecnico
{
    public int IdUsuario { get; set; }

    public string NombreTecnico { get; set; }

    public int? IdProveedor { get; set; }

    public string Status { get; set; }
}
