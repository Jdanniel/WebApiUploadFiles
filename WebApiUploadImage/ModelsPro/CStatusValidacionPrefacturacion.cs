using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CStatusValidacionPrefacturacion
    {
        public int IdStatusValidacionPrefacturacion { get; set; }
        public string DescStatusValidacionPrefacturacion { get; set; }
        public string Status { get; set; }
        public int? IsAutomatica { get; set; }
        public int? NextIdStatusAr { get; set; }
    }
}
