using BankAccountService.Core.Entities.CustomerEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Infrastructure.Builders.Customers
{
    internal class CustomerBuilder : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(1000);

            builder.HasMany(c => c.OwnerBankAccounts)
                .WithOne(b => b.Owner)
                .HasForeignKey(b => b.OwnerId);
        }
    }
}
