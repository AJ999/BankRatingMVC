using System;

namespace BankRatingLogic
{
    public interface IBankRater
    {
        decimal Rate(int CompanyID, int AnalystID, DateTime Date, int ManagementAndGovernanceOne,
            int ManagementAndGovernanceTwo, int ManagementAndGovernanceThree, int ManagementAndGovernanceFour,
            int ManagementAndGovernanceFive, int FinancialPositionOne, int FinancialPositionTwo,
            int FinancialPositionThree, int FinancialPositionFour, int CapitalPositionOne, int CapitalPositionTwo,
            int CapitalPositionThree, int JurisdictionalDomicileFactorsOne, int JurisdictionalDomicileFactorsTwo,
            int JurisdictionalDomicileFactorsThree, int JurisdictionalDomicileFactorsFour);
    }
}