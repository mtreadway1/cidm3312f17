﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSpacer.Models;

namespace FSpacer.Data
{
    public class AGCDbContext : IdentityDbContext<ApplicationUser>
    {
        public AGCDbContext(DbContextOptions<AGCDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<DriveCard>().ToTable("DriveCard");
            builder.Entity<Operator>().ToTable("Operator");
            builder.Entity<SpacerCard>().ToTable("SpacerCard");
        }

        public DbSet<FSpacer.Models.DriveCard> DriveCards { get; set; }
        public DbSet<FSpacer.Models.Operator> Operators { get; set; }
        public DbSet<FSpacer.Models.SpacerCard> SpacerCards { get; set; }
    }
}
