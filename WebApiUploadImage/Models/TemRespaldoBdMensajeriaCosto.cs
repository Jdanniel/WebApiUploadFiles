﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TemRespaldoBdMensajeriaCosto
{
    public int? IdMensajeriasPrecio { get; set; }

    public int? Zona { get; set; }

    public decimal? Kilos { get; set; }

    public int? IdTipoServicioCosto { get; set; }

    public decimal? Costo { get; set; }
}
