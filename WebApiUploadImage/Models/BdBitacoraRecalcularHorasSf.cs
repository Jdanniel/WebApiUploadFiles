﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBitacoraRecalcularHorasSf
{
    public int IdBitacoraRecalcularHorasSf { get; set; }

    public int? IdAr { get; set; }

    public DateTime? FecAtencion { get; set; }

    public DateTime? FecGarantia { get; set; }

    public DateTime? FecAlta { get; set; }
}
