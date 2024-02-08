using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject.Models.DataLayer;

public partial class PCHRContext : DbContext
{
    private readonly string? _connectionString;
    public PCHRContext()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["PCHRContext"].ConnectionString;
    }

    public PCHRContext(DbContextOptions<PCHRContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AllergyTbl> AllergyTbls { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<ImmunizationTbl> ImmunizationTbls { get; set; }

    public virtual DbSet<MedProcTbl> MedProcTbls { get; set; }

    public virtual DbSet<MedicationTbl> MedicationTbls { get; set; }

    public virtual DbSet<PatientTbl> PatientTbls { get; set; }

    public virtual DbSet<PerDetailsTbl> PerDetailsTbls { get; set; }

    public virtual DbSet<PrimaryCareTbl> PrimaryCareTbls { get; set; }

    public virtual DbSet<TestTbl> TestTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AllergyTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.AllergyId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.AllergyTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ALLERGY_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.ConditionId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.Conditions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONDITION_PATIENT_TBL");
        });

        modelBuilder.Entity<ImmunizationTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.ImmunizationId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.ImmunizationTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMMUNIZATION_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<MedProcTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.ProcedureId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.MedProcTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MED_PROC_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<MedicationTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.MedId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicationTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MEDICATION_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<PatientTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.AddressZip).IsFixedLength();
            entity.Property(e => e.PhoneHome).IsFixedLength();
            entity.Property(e => e.PhoneMobile).IsFixedLength();
            entity.Property(e => e.PrimaryId).IsFixedLength();
        });

        modelBuilder.Entity<PerDetailsTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.BloodType).IsFixedLength();

            entity.HasOne(d => d.Patient).WithOne(p => p.PerDetailsTbl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PER_DETAILS_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<PrimaryCareTbl>(entity =>
        {
            entity.Property(e => e.PrimaryId).IsFixedLength();
            entity.Property(e => e.NameFirst).IsFixedLength();
            entity.Property(e => e.NameLast).IsFixedLength();
            entity.Property(e => e.PhoneMobile).IsFixedLength();
            entity.Property(e => e.PhoneOffice).IsFixedLength();
            entity.Property(e => e.Specialty).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
        });

        modelBuilder.Entity<TestTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.TestId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.TestTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEST_TBL_PATIENT_TBL");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
