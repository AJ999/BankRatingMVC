using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRatingLogic
{
    public class BankRater : IBankRater
    {
        /// <summary>
        /// Return a Decimal Bank rating given 10 decimal inputs
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <param name="input5"></param>
        /// <param name="input6"></param>
        /// <param name="input7"></param>
        /// <param name="input8"></param>
        /// <param name="input9"></param>
        /// <param name="input10"></param>
        public decimal Rate(int CompanyID, int AnalystID, DateTime Date, int ManagementAndGovernanceOne, int ManagementAndGovernanceTwo, int ManagementAndGovernanceThree, int ManagementAndGovernanceFour, int ManagementAndGovernanceFive, int FinancialPositionOne, int FinancialPositionTwo, int FinancialPositionThree, int FinancialPositionFour, int CapitalPositionOne, int CapitalPositionTwo, int CapitalPositionThree, int JurisdictionalDomicileFactorsOne, int JurisdictionalDomicileFactorsTwo, int JurisdictionalDomicileFactorsThree, int JurisdictionalDomicileFactorsFour)
        {

            return 1.0m;
        }

    }
}
