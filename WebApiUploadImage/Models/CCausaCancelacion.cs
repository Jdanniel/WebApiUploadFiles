﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class CCausaCancelacion
    {
        public int IdCausaCancelacion { get; set; }
        public string DescCausaCancelacion { get; set; }
        public string Status { get; set; }
        public int? IdCliente { get; set; }
        public int? IdTipoCancelado { get; set; }
    }
}
