﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdUploadedFilesSendSf
{
    public int Id { get; set; }

    public string FileNameUser { get; set; }

    public string FileNameSystem { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UserId { get; set; }
}
