using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdLogUsuariosAsignacion
{
    public int IdLogUsuariosAsignacion { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }
}
