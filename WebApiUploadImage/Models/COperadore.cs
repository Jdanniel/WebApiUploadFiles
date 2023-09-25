﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class COperadore
{
    public int IdOperador { get; set; }

    public string DescOperador { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdReglasStatusAr> BdReglasStatusArs { get; set; } = new List<BdReglasStatusAr>();
}
