﻿using LinqToDB.EntityFrameworkCore.BaseTests.Models.Northwind;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinqToDB.EntityFrameworkCore.SqlServer.Tests.Models.Northwind.Mapping
{
	public class BaseEntityMap<T> : IEntityTypeConfiguration<T>
	where T: BaseEntity
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{
			builder.Property(e => e.IsDeleted).HasDefaultValue(false);
		}
	}
}
