﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdPaseListaTecnico
{
    public int IdPaseListaTecnico { get; set; }

    public int IdTecnico { get; set; }

    public DateTime FechaHora { get; set; }

    public string Status { get; set; }
}
