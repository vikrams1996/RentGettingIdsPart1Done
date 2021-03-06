﻿using mallform.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mallform.ViewModel
{
    public class TenantFormViewModel
    {



        [Required]
        [StringLength(50)]
        public string brandName { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string mobileNo { get; set; }

        [StringLength(50)]
        [Required]
        [RegularExpression(@"[A-Z]{5}\d{4}[A-Z]{1}", ErrorMessage = "Not a valid Pan Number")]
        public string panNo { get; set; }





        [Required]
       [StringLength(50)]
       
        public string startDate { get; set; }

        [Required]
        public string endDate { get; set; }

        [Required]
        public string Amount { get; set; }

        [Required]
       public int Unit { get; set; }
        public IEnumerable<Unit> Units { get; set; }

        [Required]
        public string Floor { get; set; }

        [Required]
        public string Size { get; set; }

        public int Tenant { get; set; }
        public IEnumerable<Tenant> Tenants { get; set; }

    }
}