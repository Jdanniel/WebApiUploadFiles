﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdMovInventarioValGetnet
{
    public int IdMovInventarioValGetnet { get; set; }

    public int? IdMovInv { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public bool? Status { get; set; }
}
