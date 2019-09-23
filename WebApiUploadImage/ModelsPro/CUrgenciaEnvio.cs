using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CUrgenciaEnvio
    {
        public CUrgenciaEnvio()
        {
            BdEnvios = new HashSet<BdEnvios>();
        }

        public int IdUrgenciaEnvio { get; set; }
        public string DescUrgenciaEnvio { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
    }
}
