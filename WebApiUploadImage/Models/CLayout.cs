using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CLayout
{
    public int IdLayout { get; set; }

    public string DescLayout { get; set; }

    public bool? Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
