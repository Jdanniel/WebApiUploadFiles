﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class VwCierresDiarioTecnico
{
    public int? IdTecnico { get; set; }

    public int? NoArs { get; set; }

    public string FechaCierre { get; set; }

    public int? IdProducto { get; set; }
}
