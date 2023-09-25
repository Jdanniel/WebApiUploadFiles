using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdControlRestriccionProsa
{
    public int IdControlRestriccionProsa { get; set; }

    public DateTime? FecRestriccion { get; set; }

    public int? IdUsuario { get; set; }

    public string Status { get; set; }
}
