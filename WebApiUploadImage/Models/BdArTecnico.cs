﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdArTecnico
{
    public int IdArTecnico { get; set; }

    public int? IdAr { get; set; }

    public string Segmento { get; set; }

    public int? IdCarga { get; set; }

    public int? IdTecnico { get; set; }
}
