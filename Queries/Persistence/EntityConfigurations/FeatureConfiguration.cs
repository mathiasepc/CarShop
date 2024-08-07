﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Queries.Core.Domain;

namespace Queries.Persistence.EntityConfigurations;

public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.Property(f => f.Id).IsRequired();

        builder.HasMany(f => f.Vehicle)
            .WithOne(vf => vf.Feature)
            .HasForeignKey(vf => vf.FeatureId);

    }
}