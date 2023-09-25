using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdTokensSalesforce
{
    public int IdTokenSalesforce { get; set; }

    public string Token { get; set; }

    public DateTime? FecAlta { get; set; }
}
