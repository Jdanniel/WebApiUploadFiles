﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CProductoDhl
{
    public int IdProductoDhl { get; set; }

    public string NomProductoDhl { get; set; }

    public string DescProductoDhl { get; set; }

    public string Status { get; set; }
}
