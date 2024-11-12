using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService.Core.Resources.Customers
{
    public struct UserRoles
    {
        public const string Auditor = "Auditor";
        public const string Accountant = "Accountant";
        public const string BankManager = "Bank Manager";
        public const string BranchManager = "Branch Manager";
        public const string BankTeller = "Bank Teller";
        public const string BusinessAnalyst = "Business Analyst";
        public const string BudgetAnalyst = "Budget Analyst";
        public const string FinancialAnalyst = "Financial Analyst";
        public const string FinancialManager = "Financial Manager";
        public const string CertifiedPublicAccountant = "Certified Public Accountant";
        public const string InvestmentBanker = "Investment Banker";
        public const string MortgageBanker = "Mortgage Banker";
        public const string LoanOfficer = "Loan Officer";
        public const string CreditAnalyst = "Credit Analyst";
        public const string ForeignExchangeTrader = "Foreign Exchange Trader";
        public const string HumanResourcesOfficer = "Human Resources Officer";
        public const string PublicRelationsManager = "Public Relations Manager";


        public static List<string> GetAllRoles()
        {
            return new List<string>()
            {
                Auditor,
                Accountant,
                BankManager,
                BankTeller,
                BusinessAnalyst,
                BudgetAnalyst,
                FinancialAnalyst,
                FinancialManager,
                CertifiedPublicAccountant,
                InvestmentBanker,
                MortgageBanker,
                LoanOfficer,
                CreditAnalyst,
                ForeignExchangeTrader,
                HumanResourcesOfficer,
                PublicRelationsManager
            };
        }
    }
}