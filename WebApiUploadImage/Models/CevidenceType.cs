using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CevidenceType
{
    public int EvidenceTypeId { get; set; }

    public string EvidenceDesc { get; set; }

    public int? Status { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? EvidenceNumber { get; set; }
}
