﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdTempServicioCierrePdum
{
    public int IdTempServicioCierrePda { get; set; }

    public int? IdServicio { get; set; }

    public int? IsCierrePda { get; set; }
}
