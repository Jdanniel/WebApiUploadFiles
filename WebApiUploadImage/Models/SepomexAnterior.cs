﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class SepomexAnterior
{
    public int Id { get; set; }

    public string DAsenta { get; set; }

    public string DMnpio { get; set; }

    public int? DEstado { get; set; }

    public string DCiudad { get; set; }

    public string DCp { get; set; }

    public int? IdTipoLocalidad { get; set; }
}
