﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdServicioSolucion
{
    public int IdServicioSolucion { get; set; }

    public int IdServicio { get; set; }

    public int IdSolucion { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CServicio IdServicioNavigation { get; set; }

    public virtual CSolucione IdSolucionNavigation { get; set; }
}
