﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class BdUsuarioCliente
    {
        public int IdUsuarioCliente { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
