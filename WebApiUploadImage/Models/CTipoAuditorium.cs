﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CTipoAuditorium
{
    public int IdTipoAuditoria { get; set; }

    public string DescTipoAuditoria { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdAuditoria> BdAuditoria { get; set; } = new List<BdAuditoria>();
}
