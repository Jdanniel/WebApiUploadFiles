﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CCategorium
{
    public int IdCategoria { get; set; }

    public string DescCategoria { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
