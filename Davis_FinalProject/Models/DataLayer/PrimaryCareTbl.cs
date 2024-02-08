using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject.Models.DataLayer;

[Table("PRIMARY_CARE_TBL")]
public partial class PrimaryCareTbl
{
    public PrimaryCareTbl() { }
    public PrimaryCareTbl(string id,string? lastName = null, string? firstName = null, string? title = null, string? specialty = null, string? officePhone = null, string? mobilePhone = null)
    {
        PrimaryId = id;
        NameLast = lastName;
        NameFirst = firstName;
        Title = title;
        Specialty = specialty;
        PhoneOffice = officePhone;
        PhoneMobile = mobilePhone;

    }
    [Key]
    [Column("PRIMARY_ID")]
    [StringLength(10)]
    public string PrimaryId { get; set; } = null!;

    [Column("NAME_LAST")]
    [StringLength(10)]
    public string? NameLast { get; set; } = "";

    [Column("NAME_FISRT")]
    [StringLength(10)]
    public string? NameFirst { get; set; } = "";

    [Column("TITLE")]
    [StringLength(10)]
    public string? Title { get; set; } = "";

    [Column("SPECIALTY")]
    [StringLength(10)]
    public string? Specialty { get; set; }

    [Column("PHONE_OFFICE")]
    [StringLength(10)]
    public string? PhoneOffice { get; set; }

    [Column("PHONE_MOBILE")]
    [StringLength(10)]
    public string? PhoneMobile { get; set; }
}
