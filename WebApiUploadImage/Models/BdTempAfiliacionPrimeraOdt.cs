﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdTempAfiliacionPrimeraOdt
{
    public int? IdCarga { get; set; }

    public string NoAfiliacion { get; set; }

    public string Status { get; set; }

    public string Error { get; set; }
}
