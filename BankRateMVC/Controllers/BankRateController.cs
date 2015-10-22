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
                decimal result = bankRater.Rate(inputs.Input1, inputs.Input2, inputs.Input3, inputs.Input4, inputs.Input5, inputs.Input6, inputs.Input7, inputs.Input8, inputs.Input9, inputs.Input10);
                return View(result);
           
        }

    }
}
