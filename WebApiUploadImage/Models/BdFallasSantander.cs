﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdFallasSantander
{
    public int IdFallasSantander { get; set; }

    public string ClaveSantander { get; set; }

    public int? IdFalla { get; set; }

    public string Status { get; set; }
}
