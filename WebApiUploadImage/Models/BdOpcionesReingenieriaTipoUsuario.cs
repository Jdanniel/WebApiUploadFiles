﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdOpcionesReingenieriaTipoUsuario
{
    public int IdOpcionesReingenieriaTipoUsuario { get; set; }

    public int? IdTipoUsuario { get; set; }

    public int? IdOpcionesReingenieria { get; set; }
}
