using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.DTOs.Customers.Responses
{
    public class BaseCustomerResponse
    {
        public string Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
