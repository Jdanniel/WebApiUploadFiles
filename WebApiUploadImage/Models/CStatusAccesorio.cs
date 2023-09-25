﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CStatusAccesorio
{
    public int IdStatusAccesorio { get; set; }

    public string DescStatusAccesorio { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdUnidadAccesorio> BdUnidadAccesorios { get; set; } = new List<BdUnidadAccesorio>();
}
