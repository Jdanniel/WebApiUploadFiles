﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class CReportesRetipificados
    {
        public int IdReporteRetipificados { get; set; }
        public int? IdCliente { get; set; }
        public string DescReporteRetipificados { get; set; }
        public string Status { get; set; }
    }
}
