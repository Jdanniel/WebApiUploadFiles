﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdArLogW
{
    public int IdArLogWs { get; set; }

    public string NoAr { get; set; }

    public string Estatus { get; set; }

    public string Error { get; set; }

    public DateTime? FecAlta { get; set; }
}
