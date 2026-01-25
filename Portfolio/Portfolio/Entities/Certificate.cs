using System;
using System.Collections.Generic;

namespace Portfolio.Entities;

public partial class Certificate
{
    public int CertificateId { get; set; }  
    public string? CompanyName { get; set; }

    public string? CertificateName { get; set; }

    public string? Description { get; set; }

    public string? CertificateDate { get; set; }
}
