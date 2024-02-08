using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject.Models.DataLayer;

[Table("PATIENT_TBL")]
public partial class PatientTbl
{
    public PatientTbl() { } 
    public PatientTbl(string id, string firstName, string lastName, string username, string password, string primaryID, DateTime? dob = null, string? street = null, string? city = null, string? state = null,
                      string? zip = null,  string? homePhone = null, string? mobilePhone = null, string? gender = null) 
    {
        PatientId = id;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
        AddressStreet = street;
        AddressCity = city;
        AddressState = state;
        AddressZip = zip;
        PhoneHome = homePhone;
        PhoneMobile = mobilePhone;
        UserName = username;
        Password = password;
        Gender = gender;
        PrimaryId = primaryID;
    }
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string? PatientId { get; set; }

    [Column("LAST_NAME")]
    [StringLength(20)]
    public string LastName { get; set; } = null!;

    [Column("FIRST_NAME")]
    [StringLength(20)]
    public string FirstName { get; set; } = null!;

    [Column("DATE_Of_BIRTH", TypeName = "date")]
    public DateTime? DateOfBirth { get; set; }

    [Column("ADDRESS_STREET")]
    [StringLength(50)]
    public string? AddressStreet { get; set; }

    [Column("ADDRESS_CITY")]
    [StringLength(20)]
    public string? AddressCity { get; set; }

    [Column("ADDRESS_STATE")]
    [StringLength(20)]
    public string? AddressState { get; set; }

    [Column("ADDRESS_ZIP")]
    [StringLength(10)]
    public string? AddressZip { get; set; }

    [Column("PHONE_HOME")]
    [StringLength(10)]
    public string? PhoneHome { get; set; }

    [Column("PHONE_MOBILE")]
    [StringLength(10)]
    public string? PhoneMobile { get; set; }

    [Column("PRIMARY_ID")]
    [StringLength(10)]
    public string PrimaryId { get; set; } = null!;

    [Column("USER_NAME")]
    [StringLength(20)]
    public string? UserName { get; set; }

    [Column("PASSWORD")]
    [StringLength(20)]
    public string? Password { get; set; }
    [Column("GENDER")]
    [StringLength(10)]
    public string? Gender { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<AllergyTbl> AllergyTbls { get; } = new List<AllergyTbl>();

    [InverseProperty("Patient")]
    public virtual ICollection<Condition> Conditions { get; } = new List<Condition>();

    [InverseProperty("Patient")]
    public virtual ICollection<ImmunizationTbl> ImmunizationTbls { get; } = new List<ImmunizationTbl>();

    [InverseProperty("Patient")]
    public virtual ICollection<MedProcTbl> MedProcTbls { get; } = new List<MedProcTbl>();

    [InverseProperty("Patient")]
    public virtual ICollection<MedicationTbl> MedicationTbls { get; } = new List<MedicationTbl>();

    [InverseProperty("Patient")]
    public virtual PerDetailsTbl? PerDetailsTbl { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<TestTbl> TestTbls { get; } = new List<TestTbl>();
}
