using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.DTOs.BankAccounts.BankAccountDTOs.Responses
{
    public class BaseBankAccountResponse
    {
        public long Id { get; set; }
        public string IBAN { get; set; }
        public string SWIFT_BIC_Code { get; set; }
        public string Currency { get; set; }
    }
}
