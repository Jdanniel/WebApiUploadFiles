using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CHorariosPersonal
{
    public int IdHorarioPersonal { get; set; }

    public string DescHorarioPersonal { get; set; }

    public TimeSpan? Inicio { get; set; }

    public TimeSpan? Termino { get; set; }

    public string Status { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
