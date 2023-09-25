﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraIguala
{
    public int IdBitacoraIgualas { get; set; }

    public int? IdIgualas { get; set; }

    public string StatusIni { get; set; }

    public string StatusFin { get; set; }

    public string Comentario { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
