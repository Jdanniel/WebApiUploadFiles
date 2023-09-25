﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class RegistroArchivosOriginale
{
    public int IdRegistroArchivoOriginal { get; set; }

    public string Nombre { get; set; }

    public DateTime? FecUltimaModificacion { get; set; }

    public DateTime? FecRegistro { get; set; }

    public string Carpeta { get; set; }
}
