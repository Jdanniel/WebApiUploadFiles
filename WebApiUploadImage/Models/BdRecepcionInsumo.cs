﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdRecepcionInsumo
{
    public int IdRecepcionInsumo { get; set; }

    public int? IdOrdenCompra { get; set; }

    public int? IdInsumo { get; set; }

    public double? CantidadRecepcionada { get; set; }
}
