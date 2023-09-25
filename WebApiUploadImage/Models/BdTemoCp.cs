using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdTemoCp
{
    public int IdTipoPlazaClienteCp { get; set; }

    public string Cp { get; set; }

    public int? IsCorrecto { get; set; }
}
