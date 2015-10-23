using BankRateMVC.Models;
using BankRatingLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankRateMVC.Controllers
{
    public class BankRateController : Controller
    {
        IBankRater bankRater;
        public BankRateController(IBankRater bankRater)
        {
            this.bankRater = bankRater;
        }

        // GET: BankRate
        public ActionResult Index()
        {
            return View();
        }


        // POST: BankRate/Rate
        [HttpPost]
        public ActionResult Rate(RatingInputs inputs)
        {

            // TODO: Add insert logic here
            decimal result = bankRater.Rate(inputs.CompanyID, inputs.AnalystID, inputs.Date, inputs.ManagementAndGovernanceOne, inputs.ManagementAndGovernanceTwo, inputs.ManagementAndGovernanceThree, inputs.ManagementAndGovernanceFour, inputs.ManagementAndGovernanceFive, inputs.FinancialPositionOne, inputs.FinancialPositionTwo, inputs.FinancialPositionThree, inputs.FinancialPositionFour, inputs.CapitalPositionOne, inputs.CapitalPositionTwo, inputs.CapitalPositionThree, inputs.JurisdictionalDomicileFactorsOne, inputs.JurisdictionalDomicileFactorsTwo, inputs.JurisdictionalDomicileFactorsThree, inputs.JurisdictionalDomicileFactorsFour);
            return View(result);

        }

    }
}
