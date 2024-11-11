using BankAccountService.Core.DTOs.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.DTOs.BankAccounts.BankAccountDTOs.Requests
{
    public class ManagementGetBankAccountsRequest
    {
        public string? CustomerEmail { get; set; }
        public string? CustomerPhoneNumber { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }

        public string? IBAN { get; set; }
        public string? TypeId { get; set; }
        public string? StatusId { get; set; }

        public PageParameters PageParameters { get; set; }
    }
}
