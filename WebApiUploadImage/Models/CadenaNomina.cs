﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CadenaNomina
{
    public int Id { get; set; }

    public string Url { get; set; }

    public string CadenaOriginal { get; set; }

    public string Monto { get; set; }

    public string Nombre { get; set; }
}
