﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdErroresCambioModelosMasivo
{
    public string NoSerie { get; set; }

    public string Mensaje { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
