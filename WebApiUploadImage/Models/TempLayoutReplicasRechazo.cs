using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class TempLayoutReplicasRechazo
{
    public string Odt { get; set; }

    public string CausaRechazo { get; set; }

    public string SubRechazo { get; set; }

    public string Zona { get; set; }

    public string Afiliacion { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaGeneracion { get; set; }

    public string Estatus { get; set; }

    public int? DiasSinInstalar { get; set; }

    public string IdEquipo { get; set; }

    public string IdCaja { get; set; }

    public string SubTipoServicio { get; set; }

    public string Conclusiones { get; set; }

    public string EjecutivoKa { get; set; }

    public int? IdUsuario { get; set; }
}
