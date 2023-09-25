using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdInfoErroresCargaMasiva
{
    public int IdInfoErroresCargaMasiva { get; set; }

    public string Mensaje { get; set; }

    public string Causa { get; set; }

    public string Status { get; set; }
}
