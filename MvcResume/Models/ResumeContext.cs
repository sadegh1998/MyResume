using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MvcResume.Models;

public partial class ResumeContext : DbContext
{
    public ResumeContext()
    {
    }

    public ResumeContext(DbContextOptions<ResumeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AboutMe> AboutMes { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Certificate> Certificates { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Knowledge> Knowledges { get; set; }

    public virtual DbSet<Portfolio> Portfolios { get; set; }

    public virtual DbSet<Pricing> Pricings { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<Testimonial> Testimonials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source = localhost ; Initial Catalog = Resume ; User Id = sa ; password = 123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AboutMe>(entity =>
        {
            entity.ToTable("AboutMe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Residence).HasMaxLength(50);
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.ToTable("Blog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(200);
            entity.Property(e => e.Tag).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Certificate>(entity =>
        {
            entity.ToTable("Certificate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AchiveDate).HasColumnType("date");
            entity.Property(e => e.Company).HasMaxLength(150);
            entity.Property(e => e.Image).HasMaxLength(150);
            entity.Property(e => e.SerialNumber).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.Url).HasMaxLength(350);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("Contact");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Location).HasMaxLength(500);
            entity.Property(e => e.Mobile).HasMaxLength(20);
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.ToTable("Education");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FieldOfStudy).HasMaxLength(300);
            entity.Property(e => e.GraduationDate).HasColumnType("date");
            entity.Property(e => e.UniversityName).HasMaxLength(250);
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.ToTable("Experience");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Company).HasMaxLength(250);
            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.JobTitle).HasMaxLength(250);
            entity.Property(e => e.ToDate).HasColumnType("date");
        });

        modelBuilder.Entity<Knowledge>(entity =>
        {
            entity.ToTable("Knowledge");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.ToTable("Portfolio");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(350);
            entity.Property(e => e.ProjectName).HasMaxLength(350);
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.Video).HasMaxLength(350);
        });

        modelBuilder.Entity<Pricing>(entity =>
        {
            entity.ToTable("Pricing");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Period).HasMaxLength(250);
            entity.Property(e => e.PlanName).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<Testimonial>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ProjectName).HasMaxLength(350);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
