﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraUsuariosInactivo
{
    public int IdBitacoraUsuariosInactivos { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaUltimoAcceso { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
