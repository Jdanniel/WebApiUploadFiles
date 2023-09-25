using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdContactsOnBase
{
    public int ContactId { get; set; }

    public int? SellerOnBaseId { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public int? PhoneId { get; set; }

    public DateTime? CreateDate { get; set; }
}
