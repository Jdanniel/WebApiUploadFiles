﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdMenu
    {
        public int Id { get; set; }
        public int IdMenu0 { get; set; }
        public int? IdMenu1 { get; set; }
        public int IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
