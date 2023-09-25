using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdModelosModificado
{
    public int? IdClienteViejo { get; set; }

    public int? IdModeloViejo { get; set; }

    public int? IdClienteNuevo { get; set; }

    public int? IdModeloNuevo { get; set; }
}
