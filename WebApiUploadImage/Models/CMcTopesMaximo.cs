using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CMcTopesMaximo
{
    public int IdTopeMaximo { get; set; }

    public int? IdViatico { get; set; }

    public string PrecioMaximo { get; set; }

    public string Estatus { get; set; }
}
