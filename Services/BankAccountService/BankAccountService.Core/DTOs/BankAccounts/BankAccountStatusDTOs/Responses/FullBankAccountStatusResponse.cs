﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.DTOs.BankAccounts.BankAccountStatusDTOs.Responses
{
    public class FullBankAccountStatusResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
