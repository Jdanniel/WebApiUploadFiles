﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdArDocumentosSalesforce
{
    public int IdArDocumentoSalesforce { get; set; }

    public int? IdAr { get; set; }

    public string IdDocumentoSalesforce { get; set; }

    public int? IdTipoDocumento { get; set; }
}
