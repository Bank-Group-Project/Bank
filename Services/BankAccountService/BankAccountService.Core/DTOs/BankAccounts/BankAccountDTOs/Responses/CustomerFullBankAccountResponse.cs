using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.DTOs.BankAccounts.BankAccountDTOs.Responses
{
    public class CustomerFullBankAccountResponse : BaseBankAccountResponse
    {
        public decimal OverdraftLimit { get; set; }
        public string BankName { get; set; }

        public string? Nickname { get; set; }

        public decimal Balance { get; set; }

        public int TypeId { get; set; }
        public string TypeTitle { get; set; }

        public int StatusId { get; set; }
        public string StatusTitle { get; set; }

        public DateTime? ClosingTime { get; set; }
    }
}
