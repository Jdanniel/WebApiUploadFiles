﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdModelosHomologadosSantander
{
    public int? IdCliente { get; set; }

    public int? IdModelo { get; set; }

    public string ModeloNuevo { get; set; }

    public string Aplicativo { get; set; }
}
