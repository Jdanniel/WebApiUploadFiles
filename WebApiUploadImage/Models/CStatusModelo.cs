﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CStatusModelo
{
    public int IdStatusModelo { get; set; }

    public string DescStatusModelo { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }
}
