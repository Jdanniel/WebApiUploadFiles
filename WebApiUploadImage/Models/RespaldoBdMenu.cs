﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class RespaldoBdMenu
{
    public int Id { get; set; }

    public int IdMenu0 { get; set; }

    public int? IdMenu1 { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
