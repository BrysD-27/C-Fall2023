using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject.Models.DataLayer;

[Table("PER_DETAILS_TBL")]
public partial class PerDetailsTbl
{
    public PerDetailsTbl() { }
    public PerDetailsTbl(string id, string? blood_type = null, bool? organDonor = null, bool? hivStatus = null, short? height = null, short? weight = null) {
        PatientId = id;
        BloodType = blood_type;
        OrganDonor = organDonor;
        HivStatus = hivStatus;
        HeightInches = height;
        WeightLbs = weight;
    }
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Column("BLOOD_TYPE")]
    [StringLength(10)]
    public string? BloodType { get; set; }

    [Column("ORGAN_DONOR")]
    public bool? OrganDonor { get; set; }

    [Column("HIV_STATUS")]
    public bool? HivStatus { get; set; }

    [Column("HEIGHT_INCHES")]
    public short? HeightInches { get; set; }

    [Column("WEIGHT_LBS")]
    public short? WeightLbs { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("PerDetailsTbl")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
