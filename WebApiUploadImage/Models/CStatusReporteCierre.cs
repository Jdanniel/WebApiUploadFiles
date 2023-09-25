﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CStatusReporteCierre
{
    public int IdStatusReporteCierre { get; set; }

    public string DescStatusReporteCierre { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdReporteCierre> BdReporteCierres { get; set; } = new List<BdReporteCierre>();
}
