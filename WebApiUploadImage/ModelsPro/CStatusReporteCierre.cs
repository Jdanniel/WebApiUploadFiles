﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CStatusReporteCierre
    {
        public CStatusReporteCierre()
        {
            BdReporteCierre = new HashSet<BdReporteCierre>();
        }

        public int IdStatusReporteCierre { get; set; }
        public string DescStatusReporteCierre { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdReporteCierre> BdReporteCierre { get; set; }
    }
}
