using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Models;

namespace TradingPlatformTest.ViewModels
{
    public class ItemAddViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public IFormFile File { get; set; }

        [Required]
        public double Price { get; set; }

        [Display(Name = "Is this service?")]
        public bool IsService { get; set; }

        [Display(Name = "Is it possible to ship/do in different country?")]
        public bool IsMultiCountryPossible { get; set; }

        public string UserName { get; set; }
        
        [Required]
        public Country Country { get; set; }

       public Status Status { get; set; }
    }

    public enum Status
    {
        InProcess,
        Added
    }
}
