using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mallform.Models
{
    public class Tenant
    {
        public int Id { get; set; }

      
        public string shopName { get; set; }

        
        public string brandName { get; set; }
        

    
        public string Address { get; set; }
       

       

        public string mobileNo { get; set; }

       
        public string panNo { get; set; }




    }
}