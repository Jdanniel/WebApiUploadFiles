﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdSimsFaltantesEnero
{
    public int IdSimFaltante { get; set; }

    public string NoAr { get; set; }

    public string SimInstalado { get; set; }

    public string SimRetirado { get; set; }

    public DateTime? FecProcesado { get; set; }
}
