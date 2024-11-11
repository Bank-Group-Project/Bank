using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.Recources.Customers
{
    public struct UserRoles
    {
        public const string Auditor = "Auditor";
        public const string Accountant = "Accountant";
        public const string Bank_Manager = "Bank Manager";
        public const string Branch_Manager = "Branch Manager";
        public const string Bank_Teller = "Bank Teller";
        public const string Business_Analyst = "Business Analyst";
        public const string Budget_Analyst = "Budget Analyst";
        public const string Financial_Analyst = "Financial Analyst";
        public const string Financial_Manager = "Financial Manager";
        public const string Certified_Public_Accountant = "Certified Public Accountant";
        public const string Investment_Banker = "Investment Banker";
        public const string Mortgage_Banker = "Mortgage Banker";
        public const string Loan_Officer = "Loan Officer";
        public const string Credit_Analyst = "Credit Analyst";
        public const string Foreign_Exchange_Trader = "Foreign Exchange Trader";
        public const string Human_Resources_Officer = "Human Resources Officer";
        public const string Public_Relations_Manager = "Public Relations Manager";


        public static List<string> GetAllRoles()
        {
            return new List<string>()
            {
                Auditor,
                Accountant,
                Bank_Manager,
                Bank_Teller,
                Business_Analyst,
                Budget_Analyst,
                Financial_Analyst,
                Financial_Manager,
                Certified_Public_Accountant,
                Investment_Banker,
                Mortgage_Banker,
                Loan_Officer,
                Credit_Analyst,
                Foreign_Exchange_Trader,
                Human_Resources_Officer,
                Public_Relations_Manager
            };
        }
    }
}