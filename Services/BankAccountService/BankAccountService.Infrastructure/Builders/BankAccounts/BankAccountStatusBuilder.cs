using BankAccountService.Core.Entities.BankAccountEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Infrastructure.Builders.BankAccounts
{
    internal class BankAccountStatusBuilder : IEntityTypeConfiguration<BankAccountStatus>
    {
        public void Configure(EntityTypeBuilder<BankAccountStatus> builder)
        {
            builder.HasMany(e=>e.BankAccounts)
                   .WithOne(e => e.Status)
                   .HasForeignKey(e => e.StatusId);

            builder.Property(e => e.Title)
                   .HasMaxLength(1000);

            builder.Property(e => e.Description)
                   .HasMaxLength(10000);
        }
    }
}
