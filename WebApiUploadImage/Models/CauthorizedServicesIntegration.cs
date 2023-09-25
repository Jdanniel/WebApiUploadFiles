﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CauthorizedServicesIntegration
{
    public int AuthorizedServiceIntegrationId { get; set; }

    public int? ServiceId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UserRegistered { get; set; }

    public string Status { get; set; }
}
