using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CTipoServicioSolicitudAlmacen
{
    public int IdTipoServicioSolicitudAlmacen { get; set; }

    public string DescTipoServicioSolicitudAlmacen { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacens { get; set; } = new List<BdSolicitudesAlmacen>();
}
