﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TempBdTelefono
{
    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public int? IdNegocio { get; set; }

    public int? IdAr { get; set; }
}
