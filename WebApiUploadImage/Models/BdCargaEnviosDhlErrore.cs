﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdCargaEnviosDhlErrore
{
    public int IdCargaEnvioDhlError { get; set; }

    public int? IdCargaEnvioDhl { get; set; }

    public string NoGuia { get; set; }

    public string Error { get; set; }
}
