﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdLogsCargaMasivaTablaErroresCorreo
{
    public int IdLogsCargaMasivaTablaErroresCorreo { get; set; }

    public string Odt { get; set; }

    public string Errores { get; set; }

    public int? IdCarga { get; set; }
}
