using BankAccountService.Core.Entities.BankAccountEntities;
using BankAccountService.Core.Entities.CustomerEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Infrastructure
{
    public class BankAccountServiceDbContext : DbContext
    {
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BankAccountStatus> BankAccountStatuses { get; set; }
        public virtual DbSet<BankAccountType> BankAccountTypes { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public BankAccountServiceDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
