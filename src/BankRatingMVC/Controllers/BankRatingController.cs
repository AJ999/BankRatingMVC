using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BankRatingMVC.Controllers
{
    public class BankRatingController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }



        //
        // POST: /Account/VerifyPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RateBank(decimal input1, decimal input2, decimal input3, decimal input4, decimal input5, decimal input6, decimal input7, decimal input8, decimal input9, decimal input10)
        {
           //ban
           // }
           // // If we got this far, something failed, redisplay the form
           // ModelState.AddModelError(string.Empty, "Failed to verify phone number");
            return View();
        }


    }
}
