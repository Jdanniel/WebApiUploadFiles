﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdCargasInstalacionRetiro
{
    public int IdCargasInstalacionRetiros { get; set; }

    public int? IdUsuarioCarga { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
