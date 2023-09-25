using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdArNegotiationType
{
    public int IdArTipoNegociacion { get; set; }

    public int? IdAr { get; set; }

    public string NegotiationType { get; set; }
}
