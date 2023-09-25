using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CpTipoPlazaSla
{
    public int IdTipoPlazaClienteCp { get; set; }

    public string Cp { get; set; }

    public string DescTipoPlazaCliente { get; set; }

    public string Poblacion { get; set; }

    public string DCiudad { get; set; }
}
