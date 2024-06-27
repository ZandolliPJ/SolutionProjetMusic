﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MysMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMusic.Data.Configuration
{
   public class UserConfiguration : IEntityTypeConfiguration<UserArtiste>
    {
        public void Configure(EntityTypeBuilder<UserArtiste> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
            builder
               .Property(m => m.FirstName)
               .IsRequired()
               .HasMaxLength(50);

            builder
                .Property(m => m.Username)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .ToTable("Users");
        }
    }
}
