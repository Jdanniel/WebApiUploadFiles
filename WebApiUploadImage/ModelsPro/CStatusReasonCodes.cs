﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CStatusReasonCodes
    {
        public int IdStatusReasonCodes { get; set; }
        public string StatusReasonCode { get; set; }
        public string StatusReason { get; set; }
        public string Descripcion { get; set; }
        public string StatusElavon { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
