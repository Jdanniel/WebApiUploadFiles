using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraAlmacenResponsable
{
    public int IdBitacoraAlmacenResponsable { get; set; }

    public int? IdAlmacen { get; set; }

    public int? IdResponsableAnterior { get; set; }

    public int? IdResponsableActual { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
