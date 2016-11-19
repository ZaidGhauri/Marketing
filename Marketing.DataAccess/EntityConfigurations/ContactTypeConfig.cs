﻿using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class ContactTypeConfig : EntityTypeConfiguration<ContactType>
    {
        public ContactTypeConfig()
        {
            // Primary Key
            HasKey(t => t.ContactTypeId);

            // Properties
            Property(t => t.Name).HasMaxLength(30).IsRequired();

        }
    }
}
