using BankAccountService.Core.DTOs.Customers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.DTOs.BankAccounts.BankAccountDTOs.Responses
{
    public class ManagementSimpleBankAccountResponse : BaseBankAccountResponse
    {
        public string BankName { get; set; }

        public int TypeId { get; set; }
        public string TypeTitle { get; set; }

        public int StatusId { get; set; }
        public string StatusTitle { get; set; }

        public DateTime? ClosingTime { get; set; }

        public DateTime DataCreationTime { get; set; }

        public BaseCustomerResponse Owner { get; set; }
    }
}
