﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdElavonRecovery
{
    public int IdElavonRecoveries { get; set; }

    public int? IdElavonInbox { get; set; }

    public string RequestId { get; set; }

    public string DeviceType { get; set; }

    public string DeviceTypeCategory { get; set; }

    public string Serial { get; set; }

    public string AccessoryType { get; set; }

    public string Reason { get; set; }
}
