﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdCargasNegociosOtrosCliente
{
    public int IdCargasNegociosOtrosClientes { get; set; }

    public int? IdAttach { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }
}
