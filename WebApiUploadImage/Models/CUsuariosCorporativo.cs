﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class CUsuariosCorporativo
    {
        public int IdUsuarioCorp { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdRegion { get; set; }
        public string Status { get; set; }
    }
}
