using BankAccountService.Core.Entities.CustomerEntities;
using BankAccountService.Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.Entities.BankAccountEntities
{
    public class BankAccount : Monitoring
    {
        public long Id { get; set; }

        public string IBAN { get; set; }
        public string SWIFT_BIC_Code { get; set; }
        
        public string Currency { get; set; }

        public string BankName { get; set; }
        public string BankBranch { get; set; }

        public decimal Balance { get; set; }
        public decimal OverdraftLimit { get; set; }
        public long InterestRate { get; set; }

        public DateTime? ClosingTime { get; set; }
        public string? Nickname { get; set; }

        public BankAccountType Type { get; set; }
        public int TypeId { get; set; }

        public BankAccountStatus Status { get; set; }
        public int StatusId { get; set; }

        public Customer Owner { get; set; }
        public string OwnerId { get; set; }
    }
}
