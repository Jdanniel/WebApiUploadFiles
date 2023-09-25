﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraConectividadUnidad
{
    public int IdConectividadUnidad { get; set; }

    public int? IdAr { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdConectividadVieja { get; set; }

    public int? IdConectividadNueva { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }
}
