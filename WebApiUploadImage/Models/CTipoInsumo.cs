﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CTipoInsumo
{
    public int IdTipoInsumo { get; set; }

    public string DescTipoInsumo { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CInsumosOld> CInsumosOlds { get; set; } = new List<CInsumosOld>();
}
