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
        public decimal Rate(decimal input1, decimal input2, decimal input3, decimal input4, decimal input5, decimal input6, decimal input7, decimal input8, decimal input9, decimal input10)
        {

            return 1.0m;
        }

    }
}
