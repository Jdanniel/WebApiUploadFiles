﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CConsecutivo3m
{
    public int? Consecutivo { get; set; }

    public double? Tc { get; set; }

    public string Autoriza1Email { get; set; }

    public string Autoriza2Email { get; set; }

    public string Autoriza3Email { get; set; }
}
