﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdServiciosSantander
{
    public int IdServicioSantander { get; set; }

    public string ClaveSantander { get; set; }

    public int? IdServicio { get; set; }

    public string Status { get; set; }
}
