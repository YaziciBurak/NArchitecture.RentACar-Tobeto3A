﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars").HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("Id");
        builder.Property(x => x.ModelId).HasColumnName("ModelId");
        builder.Property(x => x.ModelYear).HasColumnName("ModelYear");
        builder.Property(x => x.Plate).HasColumnName("Plate");
        builder.Property(x => x.State).HasColumnName("State");
        builder.Property(x => x.DailyPrice).HasColumnName("DailyPrice");

        builder.HasOne(x => x.Model);
        builder.HasMany(p => p.CarImages);
        builder.HasQueryFilter(x => !x.DeletedDate.HasValue);
    }
}
