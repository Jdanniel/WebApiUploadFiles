﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CTipoInventario
{
    public int IdTipoInventario { get; set; }

    public string DescTipoInventario { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdAuditoriaReporte> BdAuditoriaReportes { get; set; } = new List<BdAuditoriaReporte>();
}
