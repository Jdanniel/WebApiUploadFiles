﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TempHorario
{
    public int IdHorarios { get; set; }

    public int? IdCliente { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdHorarioAcceso { get; set; }

    public int? IdHorarioUptime { get; set; }
}
