﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdSolicitudRecoleccionInsumo
{
    public int IdSolicitudRecoleccionInsumos { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public int? IdInsumo { get; set; }

    public int? Cantidades { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionNavigation { get; set; }
}
