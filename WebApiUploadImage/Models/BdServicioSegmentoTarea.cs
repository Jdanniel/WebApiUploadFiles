﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdServicioSegmentoTarea
{
    public int IdServicioTarea { get; set; }

    public int IdServicioSegmento { get; set; }

    public int IdServicioParent { get; set; }

    public int? IsRequired { get; set; }

    public string Status { get; set; }
}
