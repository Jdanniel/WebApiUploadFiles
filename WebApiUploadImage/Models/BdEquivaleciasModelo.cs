﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdEquivaleciasModelo
{
    public int IdEquivaliencia { get; set; }

    public int? IdModelo { get; set; }

    public string DescNuevoModelo { get; set; }
}
