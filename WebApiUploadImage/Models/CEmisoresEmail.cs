﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CEmisoresEmail
{
    public int IdEmisorEmail { get; set; }

    public string DescEmisorEmail { get; set; }

    public bool? Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
