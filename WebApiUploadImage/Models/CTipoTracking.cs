﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CTipoTracking
{
    public int IdTipoTracking { get; set; }

    public string DescTipoTracking { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
