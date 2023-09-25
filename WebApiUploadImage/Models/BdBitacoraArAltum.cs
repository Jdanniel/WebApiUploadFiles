using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraArAltum
{
    public int IdArBitacoraArAlta { get; set; }

    public int? IdAr { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
