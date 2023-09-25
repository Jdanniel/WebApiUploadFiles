using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TempTipoPlazaCliente
{
    public int? IdTipoPlazaCliente { get; set; }

    public string Cp { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
