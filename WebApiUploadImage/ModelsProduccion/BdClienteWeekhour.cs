﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdClienteWeekhour
    {
        public int IdClienteWeekhour { get; set; }
        public int? IdCliente { get; set; }
        public int? IdWeekhour { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
