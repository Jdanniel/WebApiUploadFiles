﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdSolicitudesViaticosConceptosTemp
{
    public int IdSolicitudViaticosConcepto { get; set; }

    public int IdSolicitudViaticos { get; set; }

    public int IdViatico { get; set; }

    public decimal? CantidadSolicitada { get; set; }

    public decimal? CantidadAutorizada { get; set; }

    public decimal? CantidadComprobada { get; set; }

    public decimal? Adeudo { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public int? FromAutomatizacion { get; set; }

    public string Kilometros { get; set; }

    public string Observaciones { get; set; }

    public string CantidadSolicitadaReal { get; set; }
}
