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
    internal class BankAccountBuilder : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.Property(b => b.IBAN)
                .IsRequired()
                .HasMaxLength(34);

            builder.Property(b => b.SWIFT_BIC_Code)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(b => b.Currency)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(b => b.BankName)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(b => b.BankBranch)
                .HasMaxLength(1000);

            builder.Property(b => b.Balance)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(b => b.OverdraftLimit)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(b => b.InterestRate)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(b => b.Nickname)
                .HasMaxLength(1000);

            builder.HasOne(b => b.Type)
                .WithMany(b => b.BankAccounts)
                .HasForeignKey(b => b.TypeId);

            builder.HasOne(b => b.Status)
                .WithMany(b => b.BankAccounts)
                .HasForeignKey(b => b.StatusId);

            builder.HasOne(b => b.Owner)
                .WithMany(c => c.OwnerBankAccounts)
                .HasForeignKey(b => b.OwnerId);
        }
    }
}
