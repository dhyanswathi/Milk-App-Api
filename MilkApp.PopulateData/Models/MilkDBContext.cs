﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MilkApp.PopulateData.Models
{
    public partial class MilkDBContext : DbContext
    {
        public MilkDBContext()
        {
        }

        public MilkDBContext(DbContextOptions<MilkDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Milk> Milk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}