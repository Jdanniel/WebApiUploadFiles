﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdControlMasivoDevolucione
{
    public int IdControlMasivoDevolucion { get; set; }

    public int? IdUnidad { get; set; }

    public string NoSerie { get; set; }

    public string Error { get; set; }

    public string Status { get; set; }
}
