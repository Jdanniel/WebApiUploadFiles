﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CSegmento
{
    public int IdSegmento { get; set; }

    public int? IdCliente { get; set; }

    public string DescSegmento { get; set; }

    public string Descripcion { get; set; }

    public int? IsKeyAccount { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
