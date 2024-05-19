﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;

namespace VitalFlow.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Zahtjev> Zahtjev { get; set; }
        public DbSet<Termin> Termin { get; set; }
        public DbSet<Zahtjev_Hub> Zahtjev_Hub { get; set; }
        public DbSet<Termin_Hub> Termin_Hub { get; set; }
        public DbSet<Zaliha> Zaliha { get; set; }
        public DbSet<HUB> Hub { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Zahtjev>().ToTable("Zahtjev");
            modelBuilder.Entity<Termin>().ToTable("Termin");
            modelBuilder.Entity<Zahtjev_Hub>().ToTable("Zahtjev_Hub");
            modelBuilder.Entity<Termin_Hub>().ToTable("Termin_Hub");
            modelBuilder.Entity<Zaliha>().ToTable("Zaliha");
            modelBuilder.Entity<HUB>().ToTable("Hub");
            base.OnModelCreating(modelBuilder);
        }

    }
}



