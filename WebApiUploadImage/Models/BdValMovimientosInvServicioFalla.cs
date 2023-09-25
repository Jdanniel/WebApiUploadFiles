﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdValMovimientosInvServicioFalla
{
    public int IdValMovimientosInvServicioFalla { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? IdMovInventario { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
