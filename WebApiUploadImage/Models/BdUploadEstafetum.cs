﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdUploadEstafetum
{
    public int IdUploadEstafeta { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
