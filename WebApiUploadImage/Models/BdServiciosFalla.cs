﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdServiciosFalla
{
    public int IdServicioFalla { get; set; }

    public int? IdCliente { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IdOtrosClientes { get; set; }

    public int? IdProveedor { get; set; }
}
