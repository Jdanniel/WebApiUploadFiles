﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class CmailjetTemplateCatalog
{
    public int Id { get; set; }

    public string Description { get; set; }

    public long? TemplateId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UserId { get; set; }
}
