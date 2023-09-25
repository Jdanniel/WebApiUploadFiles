﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdContactosMailjet
{
    public int IdContactoMailjet { get; set; }

    public int? IdDatoListaMailjet { get; set; }

    public string NombreContacto { get; set; }

    public string Email { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
