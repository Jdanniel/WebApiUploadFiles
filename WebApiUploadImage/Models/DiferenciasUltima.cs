﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class DiferenciasUltima
{
    public int? IdUnidad { get; set; }

    public string NoSerie { get; set; }

    public string FecAlta { get; set; }

    public string Cliente { get; set; }

    public string Producto { get; set; }

    public int? IdStatusUnidad { get; set; }

    public string ResponsableActualUnidad { get; set; }

    public string ResponsableUltimoMovimiento { get; set; }

    public string StatusActualUnidad { get; set; }

    public string StatusUltimoBitacoraUnidad { get; set; }

    public string FechaUltimoMovimiento { get; set; }

    public string UltimoUsuario { get; set; }
}
