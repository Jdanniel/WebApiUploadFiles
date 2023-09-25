using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CTipoSoporteTecnico
{
    public int IdTipoSoporteTecnico { get; set; }

    public string DescTipoSoporteTecnico { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdSoporteTecnico> BdSoporteTecnicos { get; set; } = new List<BdSoporteTecnico>();
}
