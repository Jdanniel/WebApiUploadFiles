﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraTipoPlazaCliente
{
    public int IdBitacoraTipoPlazaCliente { get; set; }

    public int? IdTipoPlaza { get; set; }

    public string Cp { get; set; }

    public string Descripcion { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
