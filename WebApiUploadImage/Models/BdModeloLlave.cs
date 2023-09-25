﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdModeloLlave
{
    public int IdModeloLlave { get; set; }

    public int? IdModelo { get; set; }

    public int? IdLlave { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CLlafe IdLlaveNavigation { get; set; }

    public virtual CModelo IdModeloNavigation { get; set; }
}
