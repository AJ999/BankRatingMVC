using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankRateMVC.Models
{
    public class RatingInputs
    {
        [Required]
        [Display(Name = "Company ID")]
        public int CompanyID { get; set; }
        [Required]
        [Display(Name = "Analyst ID")]
        public int AnalystID { get; set; }
        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Depth and quality of management")]
        public int ManagementAndGovernanceOne { get; set; }
        [Required]
        [Display(Name = "Corporate/ Management  Strategy")]
        public int ManagementAndGovernanceTwo { get; set; }
        [Required]
        [Display(Name = "Quality and Strength of Board Oversight")]
        public int ManagementAndGovernanceThree { get; set; }
        [Required]
        [Display(Name = "Transparency and Quality of Reporting")]
        public int ManagementAndGovernanceFour { get; set; }
        [Required]
        [Display(Name = "Operational Risk Control Environment")]
        public int ManagementAndGovernanceFive { get; set; }
        [Required]
        [Display(Name = "Quality of Earnings")]
        public int FinancialPositionOne { get; set; }
        [Required]
        [Display(Name = "Quality of Assets")]
        public int FinancialPositionTwo { get; set; }
        [Required]
        [Display(Name = "Contingent Liabilities")]
        public int FinancialPositionThree { get; set; }
        [Required]
        [Display(Name = "Financial Risk Control Environment")]
        public int FinancialPositionFour { get; set; }
        [Required]
        [Display(Name = "Strength of Capital Position")]
        public int CapitalPositionOne { get; set; }
        [Required]
        [Display(Name = "Ability to raise loss absorbing capital?")]
        public int CapitalPositionTwo { get; set; }
        [Required]
        [Display(Name = "Resilience to Liquidity/Funding shocks")]
        public int CapitalPositionThree { get; set; }
        [Required]
        [Display(Name = "Rigour of Regulatory framework")]
        public int JurisdictionalDomicileFactorsOne { get; set; }
        [Required]
        [Display(Name = "Quality of regulatory oversight")]
        public int JurisdictionalDomicileFactorsTwo { get; set; }
        [Required]
        [Display(Name = "Capacity of home state to offer financial support to institution")]
        public int JurisdictionalDomicileFactorsThree { get; set; }
        [Required]
        [Display(Name = "Propensity for home state to offer support for institution")]
        public int JurisdictionalDomicileFactorsFour { get; set; }
    }


}
