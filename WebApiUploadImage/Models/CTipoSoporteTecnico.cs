﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class CTipoSoporteTecnico
    {
        public CTipoSoporteTecnico()
        {
            BdSoporteTecnico = new HashSet<BdSoporteTecnico>();
        }

        public int IdTipoSoporteTecnico { get; set; }
        public string DescTipoSoporteTecnico { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdSoporteTecnico> BdSoporteTecnico { get; set; }
    }
}
