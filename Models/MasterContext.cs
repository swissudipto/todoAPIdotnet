using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace todoAPIdotnet.Models;

public partial class MasterContext : DbContext
{
    public MasterContext()
    {
    }

    public MasterContext(DbContextOptions<MasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tasktable> Tasktables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tasktable>(entity =>
        {
            entity.HasKey(e => e.Tasknumber).HasName("PK_tasktable_Tasknumber");

            entity.ToTable("tasktable");

            entity.Property(e => e.Tasknumber)
                .ValueGeneratedNever()
                .HasColumnName("tasknumber");
            entity.Property(e => e.Taskenddate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("taskenddate");
            entity.Property(e => e.Taskname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("taskname");
            entity.Property(e => e.Taskstartdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("taskstartdate");
            entity.Property(e => e.Taskstatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("taskstatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
