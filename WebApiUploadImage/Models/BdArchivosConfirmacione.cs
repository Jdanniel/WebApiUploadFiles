﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdArchivosConfirmacione
{
    public int IdArchivoConfirmaciones { get; set; }

    public int? IdCargaConfirmaciones { get; set; }

    public string NombreArchivoConfirmacionesSystem { get; set; }

    public string NombreArchivoConfirmacionesUser { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual BdCargasConfirmacione IdCargaConfirmacionesNavigation { get; set; }
}
