﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CMcViaticosMotivo
{
    public int IdMotivo { get; set; }

    public string Motivo { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
