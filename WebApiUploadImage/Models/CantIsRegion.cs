﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CantIsRegion
{
    public string Region { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Cantidad { get; set; }
}
