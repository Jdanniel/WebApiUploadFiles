﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdBitacoraJobs
    {
        public int IdBitacoraJob { get; set; }
        public string JobName { get; set; }
        public DateTime? Fecha { get; set; }
        public string Status { get; set; }
    }
}
