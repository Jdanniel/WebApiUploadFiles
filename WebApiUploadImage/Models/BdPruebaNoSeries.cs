﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdPruebaNoSeries
{
    public string ValidacionLetras { get; set; }

    public string ValidacionNumero { get; set; }

    public string ValidacionLog { get; set; }

    public string NoSerie { get; set; }

    public int? TotalNumeros { get; set; }

    public int? TotalLetras { get; set; }

    public int? IdModelo { get; set; }
}
