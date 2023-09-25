﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdSolicitudRecoleccionModelo
{
    public int IdSolicitudRecoleccionModelo { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public int? IdModelo { get; set; }

    public int? NoUnidades { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionNavigation { get; set; }
}
