﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CLogro
{
    public int IdTipoLogro { get; set; }

    public string DescLogro { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
