﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdBorrarTablaTinte
{
    public string Paso { get; set; }

    public string Descripcion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? Fecha { get; set; }
}
