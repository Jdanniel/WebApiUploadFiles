﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdDbBackup
    {
        public int IdDbBackup { get; set; }
        public string FilePath { get; set; }
        public DateTime FecAlta { get; set; }
        public DateTime? FecStatus { get; set; }
        public string Status { get; set; }
    }
}
