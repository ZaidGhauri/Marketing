﻿using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            // Primary Key
            HasKey(cat => cat.Id);
            // Properties
            Property(cat => cat.Name).HasMaxLength(50).IsRequired();
            HasRequired(p => p.WebSite).WithMany().HasForeignKey(p => p.WebSiteId).WillCascadeOnDelete(false);
            HasRequired(p => p.Picture).WithMany().HasForeignKey(p => p.PictureId).WillCascadeOnDelete(false);
        }
    }
}
