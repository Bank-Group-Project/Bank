using BankAccountService.Core.Entities.BankAccountEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.Entities.CustomerEntities
{
    public class Customer
    {
        public string Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<BankAccount> OwnerBankAccounts { get; set; } = new HashSet<BankAccount>();
    }
}
